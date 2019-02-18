using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Utils;
using PrefeituraConecta.MVC.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using PrefeituraConecta.API.Negocio;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class AutenticacaoController : Controller
    {
       
        

        private UsuarioBS bs = new UsuarioBS();

        // GET: Autenticacao
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroUsuarioViewModel viewmodel)
        {
            

            if (!ModelState.IsValid)
            {
                return View(viewmodel);
            }

            var source = bs.ObterListaUsuario();

         

            var listaUsuario = Mapper.Map<List<Usuario>>(source);



            if (listaUsuario.Count(u => u.Login == viewmodel.Login) > 0)
            {
                ModelState.AddModelError("Login", "Esse Login já está em uso");
                return View(viewmodel);
            }

            Usuario novoUsuario = new Usuario
            {
                Nome = viewmodel.Nome,
                Login = viewmodel.Login,
                Senha = Hash.GerarHash(viewmodel.Senha)
            };

            bool retorno = bs.Inserir(Mapper.Map<PrefeituraConecta.API.Entidades.Usuario>(novoUsuario));

         

            if (retorno)
            {
                TempData["Mensagem"] = "Cadastro realizado com sucesso. Efetue Login.";
            }
            

            return RedirectToAction("Login");

        }

        public ActionResult Login(string ReturnUrl)
        {
            var viewmodel = new LoginViewModel
            {
                urlRetorno = ReturnUrl
            };

            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewmodel)
        {
            
            if (!ModelState.IsValid)
            {
                return View(viewmodel);
            }

            var source = bs.ObterListaUsuario().FirstOrDefault(u => u.Login == viewmodel.Login);
            var usuario = Mapper.Map<Usuario>(source);

            if (usuario == null)
            {
                ModelState.AddModelError("Login", "Login incorreto!");
                return View(viewmodel);
            }

            if (usuario.Senha != Hash.GerarHash(viewmodel.Senha))
            {
                ModelState.AddModelError("Senha", "Senha incorreta!");
                return View(viewmodel);
            }

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim("Login", usuario.Login),
                new Claim(ClaimTypes.Role, usuario.Tipo.ToString())
            }, "ApplicationCookie");

            Request.GetOwinContext().Authentication.SignIn(identity);

            if (!String.IsNullOrWhiteSpace(viewmodel.urlRetorno) || Url.IsLocalUrl(viewmodel.urlRetorno))
                return Redirect(viewmodel.urlRetorno);
            else
                return RedirectToAction("Index", "Painel");
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Voltar()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
