using PrefeituraConecta.API.Entidades;
using PrefeituraConecta.API.Utils.Enumeradores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Dados
{
    
    public class UsuarioDB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public List<Usuario> ObterListaUsuario()
        {
            List<Usuario> ListaObj = new List<Usuario>();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_SEL_USUARIOS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Usuario obj = new Usuario();

                    obj.Id = dr["Id"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["Id"].ToString());

                    obj.Nome = dr["Nome"].ToString();

                    obj.Login = dr["Login"].ToString();

                    obj.Senha = dr["Senha"].ToString();

                    obj.Tipo = (TipoUsuarioEnum) Enum.Parse(typeof(TipoUsuarioEnum),dr["Tipo"].ToString());


                    ListaObj.Add(obj);

                }

                return ListaObj;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            finally

            {

                con.Close();

            }
        }

        public bool AlterarUsuario(Usuario usuario)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_UPD_USUARIO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Login", usuario.Login);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Tipo", (int)usuario.Tipo);


                return cmd.ExecuteNonQuery() != 0 ? true : false;

            }

            catch (Exception ex)

            {

                throw ex;  // retorna mensagem de erro

            }

            finally

            {

                con.Close();

            }
        }

        public bool InserirUsuario(Usuario novoUsuario)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_INS_USUARIO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
                cmd.Parameters.AddWithValue("@Login", novoUsuario.Login);
                cmd.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
                cmd.Parameters.AddWithValue("@Tipo", (int)novoUsuario.Tipo);
              

                return cmd.ExecuteNonQuery() != 0 ? true : false;

            }

            catch (Exception ex)

            {

                throw ex;  // retorna mensagem de erro

            }

            finally

            {

                con.Close();

            }
        }
    }
}