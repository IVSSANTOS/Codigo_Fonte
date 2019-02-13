using PrefeituraConecta.API.Dados;
using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Negocio
{
    public class UsuarioBS
    {
        UsuarioDB db = new UsuarioDB();

        public List<Usuario> ObterListaUsuario()
        {
            try
            {
                return db.ObterListaUsuario();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Inserir(Usuario novoUsuario)
        {
            try
            {
                return db.InserirUsuario(novoUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Alterar(Usuario usuario)
        {
            try
            {
                return db.AlterarUsuario(usuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
