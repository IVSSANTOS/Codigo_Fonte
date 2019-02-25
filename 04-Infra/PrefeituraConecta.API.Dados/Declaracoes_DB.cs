using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Dados
{
    public class Declaracoes_DB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public Declaracoes ObterContador()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_EMPRESAS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.EMPRESAS = dr["EMPRESAS"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["EMPRESAS"].ToString());

                }

                return Contador;

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
    }
}
