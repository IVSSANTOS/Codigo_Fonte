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
    public class VALOR_APURADO_EMPRESAS_DB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public List<VALOR_APURADO_EMPRESAS> ObterLista()
        {
            List<VALOR_APURADO_EMPRESAS> ListaObj = new List<VALOR_APURADO_EMPRESAS>();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_SEL_VALOR_APURADO_EMPRESAS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    VALOR_APURADO_EMPRESAS obj = new VALOR_APURADO_EMPRESAS();

                    //obj.ID_CONTRIBUINTE = dr["ID_CONTRIBUINTE"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_CONTRIBUINTE"].ToString());

                    obj.CNPJMATRIZ = dr["CNPJMATRIZ"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["CNPJMATRIZ"].ToString());

                    obj.NOME = dr["NOME"].ToString();

                    obj.RPA = dr["RPA"].ToString().Equals(string.Empty) ? 0 : Convert.ToDecimal(dr["RPA"].ToString());

                    obj.ID_PREFEITURA = dr["ID_PREFEITURA"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_PREFEITURA"].ToString());

                    obj.VALOR_APURADO_DE_ISS = dr["VALOR_APURADO_DE_ISS"].ToString().Equals(string.Empty) ? 0 : Convert.ToDecimal(dr["VALOR_APURADO_DE_ISS"].ToString());

                    obj.VALOR_APURADO_DE_ICMS = dr["VALOR_APURADO_DE_ICMS"].ToString().Equals(string.Empty) ? 0 : Convert.ToDecimal(dr["VALOR_APURADO_DE_ICMS"].ToString());

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
