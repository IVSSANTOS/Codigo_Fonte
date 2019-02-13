using PrefeituraConecta.API.Entidades.Arquivos.PGDASD;
using PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PrefeituraConecta.API.Dados
{
    public class SimplesNacionaDB
    {
        private string connectionString = new DBConfiguration().GetconfigurationStringSQL();

        public bool InserirDeclaracaoSimplesNacional(int COD_TOM, decimal Pgdasd_ID_Declaracao,
                    List<REG_AAAAA_ARQUIVO_DIGITAL> Lista_REG_AAAAA,
                    List<REG_00000_CONTRIBUINTE_DADOS_APURACAO> Lista_REG_00000,
                    List<REG_00001_PROCESSO_NAO_OPTANTE> Lista_REG_00001,
                    List<REG_01000_VALOR_APURADO_CALCULO> Lista_REG_01000,
                    List<REG_01100_PERFIL_DAS> Lista_REG_01100,
                    List<REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO> Lista_REG_01500,
                    List<REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO> Lista_REG_01501,
                    List<REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO> Lista_REG_01502,
                    List<REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS> Lista_REG_02000,
                    List<REG_03000_ESTABELECIMENTO_FILIAL> Lista_REG_03000,
                    List<REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO> Lista_REG_03100,
                    List<REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A> Lista_REG_03110,
                    List<REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A> Lista_REG_03111,
                    List<REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A> Lista_REG_03112,
                    List<REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B> Lista_REG_03120,
                    List<REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B> Lista_REG_03121,
                    List<REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B> Lista_REG_03122,
                    List<REG_03122_LAYOUT_ATE_2017> Lista_REG_03122_LAYOUT_ATE_2017,
                    List<REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C> Lista_REG_03130,
                    List<REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C> Lista_REG_03131,
                    List<REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C> Lista_REG_03132,
                    List<REG_03500_FOLHA_SALARIOS> Lista_REG_03500,
                    List<REG_04000_PERFIL> Lista_REG_04000,
                    List<REG_99999_ENCERRAMENTO_BLOCO> Lista_REG_99999)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try

            {
                con.Open();

                SqlCommand cmd = new SqlCommand("[DBO].[SP_INS_DECLARACAO_SIMPLES_NACIONAL_XML]", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@COD_TOM", COD_TOM);
                cmd.Parameters.AddWithValue("@PGDASD_ID_DECLARACAO", Pgdasd_ID_Declaracao);
              
                if (Lista_REG_AAAAA != null && Lista_REG_AAAAA.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_AAAAA_ARQUIVO_DIGITAL", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_AAAAA_ARQUIVO_DIGITAL>>(Lista_REG_AAAAA));
                else
                    cmd.Parameters.AddWithValue("@REG_AAAAA_ARQUIVO_DIGITAL", DBNull.Value);


                cmd.Parameters.AddWithValue("@REG_00000_CONTRIBUINTE_DADOS_APURACAO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_00000_CONTRIBUINTE_DADOS_APURACAO>>(Lista_REG_00000));

                if (Lista_REG_00001 != null && Lista_REG_00001.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_00001_PROCESSO_NAO_OPTANTE", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_00001_PROCESSO_NAO_OPTANTE>>(Lista_REG_00001));
                else
                    cmd.Parameters.AddWithValue("@REG_00001_PROCESSO_NAO_OPTANTE", DBNull.Value);


                if (Lista_REG_01000 != null && Lista_REG_01000.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_01000_VALOR_APURADO_CALCULO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_01000_VALOR_APURADO_CALCULO>>(Lista_REG_01000));
                else
                    cmd.Parameters.AddWithValue("@REG_01000_VALOR_APURADO_CALCULO", DBNull.Value);


                if (Lista_REG_01100 != null && Lista_REG_01100.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_01100_PERFIL_DAS", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_01100_PERFIL_DAS>>(Lista_REG_01100));
                else
                    cmd.Parameters.AddWithValue("@REG_01100_PERFIL_DAS", DBNull.Value);

                if (Lista_REG_01500 != null && Lista_REG_01500.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO>>(Lista_REG_01500));
                else
                    cmd.Parameters.AddWithValue("@REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO", DBNull.Value);

                if (Lista_REG_01501 != null && Lista_REG_01501.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO>>(Lista_REG_01501));
                else
                    cmd.Parameters.AddWithValue("@REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO", DBNull.Value);

                if (Lista_REG_01502 != null && Lista_REG_01502.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO>>(Lista_REG_01502));
                else
                    cmd.Parameters.AddWithValue("@REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO", DBNull.Value);

                if (Lista_REG_02000 != null && Lista_REG_02000.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS>>(Lista_REG_02000));
                else
                    cmd.Parameters.AddWithValue("@REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS", DBNull.Value);

                if (Lista_REG_03000 != null && Lista_REG_03000.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03000_ESTABELECIMENTO_FILIAL", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03000_ESTABELECIMENTO_FILIAL>>(Lista_REG_03000));
                else
                    cmd.Parameters.AddWithValue("@REG_03000_ESTABELECIMENTO_FILIAL", DBNull.Value);


                if (Lista_REG_03100 != null && Lista_REG_03100.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO>>(Lista_REG_03100));
                else
                    cmd.Parameters.AddWithValue("@REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO", DBNull.Value);


                if (Lista_REG_03110 != null && Lista_REG_03110.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A>>(Lista_REG_03110));
                else
                    cmd.Parameters.AddWithValue("@REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A", DBNull.Value);


                if (Lista_REG_03111 != null && Lista_REG_03111.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A>>(Lista_REG_03111));
                else
                    cmd.Parameters.AddWithValue("@REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A", DBNull.Value);

                if (Lista_REG_03112 != null && Lista_REG_03112.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A>>(Lista_REG_03112));
                else
                    cmd.Parameters.AddWithValue("@REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A", DBNull.Value);

                if (Lista_REG_03120 != null && Lista_REG_03120.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B>>(Lista_REG_03120));
                else
                    cmd.Parameters.AddWithValue("@REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B", DBNull.Value);


                if (Lista_REG_03121 != null && Lista_REG_03121.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B>>(Lista_REG_03121));
                else
                    cmd.Parameters.AddWithValue("@REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B", DBNull.Value);

                if (Lista_REG_03122 != null && Lista_REG_03122.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B>>(Lista_REG_03122));
                else
                    cmd.Parameters.AddWithValue("@REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B", DBNull.Value);

                if (Lista_REG_03122_LAYOUT_ATE_2017 != null && Lista_REG_03122_LAYOUT_ATE_2017.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03122_LAYOUT_ATE_2017", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03122_LAYOUT_ATE_2017>>(Lista_REG_03122_LAYOUT_ATE_2017));
                else
                    cmd.Parameters.AddWithValue("@REG_03122_LAYOUT_ATE_2017", DBNull.Value);

                if (Lista_REG_03130 != null && Lista_REG_03130.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C>>(Lista_REG_03130));
                else
                    cmd.Parameters.AddWithValue("@REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C", DBNull.Value);

                if (Lista_REG_03131 != null && Lista_REG_03131.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C>>(Lista_REG_03131));
                else
                    cmd.Parameters.AddWithValue("@REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C", DBNull.Value);

                if (Lista_REG_03132 != null && Lista_REG_03132.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C>>(Lista_REG_03132));
                else
                    cmd.Parameters.AddWithValue("@REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C", DBNull.Value);

                if (Lista_REG_03500 != null && Lista_REG_03500.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_03500_FOLHA_SALARIOS", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_03500_FOLHA_SALARIOS>>(Lista_REG_03500));
                else
                    cmd.Parameters.AddWithValue("@REG_03500_FOLHA_SALARIOS", DBNull.Value);

                if (Lista_REG_04000 != null && Lista_REG_04000.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_04000_PERFIL", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_04000_PERFIL>>(Lista_REG_04000));
                else
                    cmd.Parameters.AddWithValue("@REG_04000_PERFIL", DBNull.Value);

                if (Lista_REG_99999 != null && Lista_REG_99999.Count > 0)

                    cmd.Parameters.AddWithValue("@REG_99999_ENCERRAMENTO_BLOCO", Utils.Serializacao.Serializacao_XML.Serializar<List<REG_99999_ENCERRAMENTO_BLOCO>>(Lista_REG_99999));
                else
                    cmd.Parameters.AddWithValue("@REG_99999_ENCERRAMENTO_BLOCO", DBNull.Value);
            

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
