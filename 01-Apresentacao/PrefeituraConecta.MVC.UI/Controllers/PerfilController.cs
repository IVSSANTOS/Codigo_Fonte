using AutoMapper;
using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Utils;
using PrefeituraConecta.MVC.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class PerfilController : Controller
    {
       
        MapperConfiguration config = new MapperConfiguration(cfg =>
        {

            cfg.CreateMap<Usuario, PrefeituraConecta.API.Entidades.Usuario>();

        });

        private UsuarioBS bs = new UsuarioBS();


        [Authorize]
        public ActionResult AlterarSenha()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult AlterarSenha(AlterarSenhaViewModel viewModel)
        {
            IMapper iMapper = config.CreateMapper();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var identity = User.Identity as ClaimsIdentity;
            var login = identity.Claims.FirstOrDefault(c => c.Type == "Login").Value;
            
            var source = bs.ObterListaUsuario().FirstOrDefault(u => u.Login == login);
            var usuario = iMapper.Map<Usuario>(source);

            if (Hash.GerarHash(viewModel.SenhaAtual) != usuario.Senha)
            {
                ModelState.AddModelError("SenhaAtual", "Senha Incorreta");
                return View();
            }

            usuario.Senha = Hash.GerarHash(viewModel.NovaSenha);
                                  
            
            bool retorno =  bs.Alterar(iMapper.Map<PrefeituraConecta.API.Entidades.Usuario>(usuario));

            if (retorno)
            {
                TempData["Mesagem"] = "Senha alterada com sucesso";
            }
                        

            return RedirectToAction("Index", "Painel");
        }
    }
}