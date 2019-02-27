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

        public decimal ObterContadorEmpresas()
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

                return Contador.EMPRESAS;

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
        public decimal ObterContadorTransmitidas()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_TRANSMITIDAS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.TRANSMITIDAS = dr["TRANSMITIDAS"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["TRANSMITIDAS"].ToString());

                }

                return Contador.TRANSMITIDAS;

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
        public decimal ObterContadorReceitasDeclaradasIssqn()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_RECEITAS_DECLARADAS_ISSQN]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.RECEITAS_DECLARADAS_ISSQN = dr["RECEITAS_DECLARADAS_ISSQN"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["RECEITAS_DECLARADAS_ISSQN"].ToString());

                }

                return Contador.RECEITAS_DECLARADAS_ISSQN;

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
        public decimal ObterContadorReceitasDeclaradasIcms()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_RECEITAS_DECLARADAS_ICMS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.RECEITAS_DECLARADAS_ICMS = dr["RECEITAS_DECLARADAS_ICMS"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["RECEITAS_DECLARADAS_ICMS"].ToString());

                }

                return Contador.RECEITAS_DECLARADAS_ICMS;

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
        public decimal ObterContadorServicosSemRetencao()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_SEM_RETENCAO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_SEM_RETENCAO = dr["SERVICOS_SEM_RETENCAO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_SEM_RETENCAO"].ToString());

                }

                return Contador.SERVICOS_SEM_RETENCAO;

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
        public decimal ObterContadorServicosComRetencao()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_COM_RETENCAO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_COM_RETENCAO = dr["SERVICOS_COM_RETENCAO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_COM_RETENCAO"].ToString());

                }

                return Contador.SERVICOS_COM_RETENCAO;

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
        public decimal ObterContadorServicosOutrosMunicipios()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_OUTROS_MUNICIPIOS]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_OUTROS_MUNICIPIOS = dr["SERVICOS_OUTROS_MUNICIPIOS"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_OUTROS_MUNICIPIOS"].ToString());

                }

                return Contador.SERVICOS_OUTROS_MUNICIPIOS;

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
        public decimal ObterContadorServicosLocacao()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_LOCACAO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_LOCACAO = dr["SERVICOS_LOCACAO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_LOCACAO"].ToString());

                }

                return Contador.SERVICOS_LOCACAO;

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
        public decimal ObterContadorServicosContabilidade()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_CONTABILIDADE]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_CONTABILIDADE = dr["SERVICOS_CONTABILIDADE"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_CONTABILIDADE"].ToString());

                }

                return Contador.SERVICOS_CONTABILIDADE;

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
        public decimal ObterContadorServicosExterior()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_SERVICOS_EXTERIOR]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.SERVICOS_EXTERIOR = dr["SERVICOS_EXTERIOR"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["SERVICOS_EXTERIOR"].ToString());

                }

                return Contador.SERVICOS_EXTERIOR;

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
        public decimal ObterContadorComercioMercadoInterno()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_COMERCIO_MERCADO_INTERNO]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.COMERCIO_MERCADO_INTERNO = dr["COMERCIO_MERCADO_INTERNO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["COMERCIO_MERCADO_INTERNO"].ToString());

                }

                return Contador.COMERCIO_MERCADO_INTERNO;

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
        public decimal ObterContadorComercioExterior()
        {
            Declaracoes Contador = new Declaracoes();

            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_DECLARACOES_COMERCIO_EXTERIOR]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    Contador.COMERCIO_EXTERIOR = dr["COMERCIO_EXTERIOR"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(dr["COMERCIO_EXTERIOR"].ToString());

                }

                return Contador.COMERCIO_EXTERIOR;

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
