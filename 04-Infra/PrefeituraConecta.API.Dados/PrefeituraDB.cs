using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PrefeituraConecta.API.Dados
{
    public class PrefeituraDB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public List<Prefeitura> ObterListaPrefeitura()
        {
            List<Prefeitura> ListaObj = new List<Prefeitura>();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_SEL_PREFEITURAS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Prefeitura obj = new Prefeitura();

                    obj.ID_PREFEITURA = dr["ID_PREFEITURA"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_PREFEITURA"].ToString());

                    obj.DESCRICAO = dr["DESCRICAO"].ToString();


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
    }
}
