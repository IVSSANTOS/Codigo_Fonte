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
    public class FiltroSimplesNacional_DB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public FiltroSimplesNacional ObterFiltroSimplesNacional()
        {
            FiltroSimplesNacional obj = new FiltroSimplesNacional();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_SEL_FILTRO_SIMPLES_NACIONAL]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    obj.ID_CONSULTA = dr["ID_CONSULTA"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_CONSULTA"].ToString());

                    obj.ID_PREFEITURA = dr["ID_PREFEITURA"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_PREFEITURA"].ToString());

                    obj.ID_USUARIO = dr["ID_USUARIO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["ID_USUARIO"].ToString());

                    obj.Consulta = dr["CONSULTA"].ToString();

                    obj.ConsolidadoPor = dr["CONSOLIDADO_POR"].ToString();

                    obj.TipoEmpresa = dr["TIPO_EMPRESA"].ToString();

                    obj.TipoDeclaracao = dr["TIPO_DECLARACAO"].ToString();

                    obj.Regime = dr["REGIME"].ToString();

                    obj.PeriodoApuracaoDe = dr["PERIODO_APURACAO_DE"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["PERIODO_APURACAO_DE"].ToString());

                    obj.PeriodoApuracaoAte = dr["PERIODO_APURACAO_ATE"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(dr["PERIODO_APURACAO_ATE"].ToString());
                    
                    obj.CNPJ = dr["CNPJ"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["CNPJ"].ToString());

                }

                return obj;

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

        public bool InserirFiltroSimplesNacional(FiltroSimplesNacional filtroSimplesNacional)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_INS_FILTRO_SIMPLES_NACIONAL]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_PREFEITURA", filtroSimplesNacional.ID_PREFEITURA);
                cmd.Parameters.AddWithValue("@ID_USUARIO", filtroSimplesNacional.ID_USUARIO);
                cmd.Parameters.AddWithValue("@CONSULTA", filtroSimplesNacional.Consulta);
                cmd.Parameters.AddWithValue("@CONSOLIDADO_POR", filtroSimplesNacional.ConsolidadoPor);
                cmd.Parameters.AddWithValue("@TIPO_EMPRESA", filtroSimplesNacional.TipoEmpresa);
                cmd.Parameters.AddWithValue("@TIPO_DECLARACAO", filtroSimplesNacional.TipoDeclaracao);
                cmd.Parameters.AddWithValue("@REGIME", filtroSimplesNacional.Regime);
                cmd.Parameters.AddWithValue("@PERIODO_APURACAO_DE", filtroSimplesNacional.PeriodoApuracaoDe);
                cmd.Parameters.AddWithValue("@PERIODO_APURACAO_ATE", filtroSimplesNacional.PeriodoApuracaoAte);
                cmd.Parameters.AddWithValue("@CNPJ", filtroSimplesNacional.CNPJ);

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
