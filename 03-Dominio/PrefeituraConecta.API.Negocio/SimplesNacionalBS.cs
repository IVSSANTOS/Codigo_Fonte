using PrefeituraConecta.API.Utils.Enumeradores.Arquivos.PGDASD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PrefeituraConecta.API.Entidades.Arquivos.PGDASD;
using System.Linq;
using System.Reflection;
using PrefeituraConecta.API.Entidades.Arquivos;
using PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade;
using PrefeituraConecta.API.Dados;
using PrefeituraConecta.API.Entidades;

namespace PrefeituraConecta.API.Negocio
{
    public class SimplesNacionalBS
    {
        ArquivoTexto arquivo = new ArquivoTexto();
        PrefeituraDB prefeituraDB = new PrefeituraDB();
        SimplesNacionaDB simplesNacionaDB = new SimplesNacionaDB();

        public bool ImportarArquivo_PGDASD(string pathArquivo)
        {


            #region Declaração das listas

            List<Prefeitura> ListaPefeituras = new List<Prefeitura>();

            List<REG_AAAAA_ARQUIVO_DIGITAL> Lista_REG_AAAAA = new List<REG_AAAAA_ARQUIVO_DIGITAL>();

            List<REG_00000_CONTRIBUINTE_DADOS_APURACAO> Lista_REG_00000 = new List<REG_00000_CONTRIBUINTE_DADOS_APURACAO>();

            List<REG_00000_CONTRIBUINTE_DADOS_APURACAO> Lista_REG_00000_AUX = new List<REG_00000_CONTRIBUINTE_DADOS_APURACAO>();

            List<REG_00001_PROCESSO_NAO_OPTANTE> Lista_REG_00001 = new List<REG_00001_PROCESSO_NAO_OPTANTE>();

            List<REG_01000_VALOR_APURADO_CALCULO> Lista_REG_01000 = new List<REG_01000_VALOR_APURADO_CALCULO>();

            List<REG_01100_PERFIL_DAS> Lista_REG_01100 = new List<REG_01100_PERFIL_DAS>();

            List<REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO> Lista_REG_01500 = new List<REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO>();

            List<REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO> Lista_REG_01501 = new List<REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO>();

            List<REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO> Lista_REG_01502 = new List<REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO>();

            List<REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS> Lista_REG_02000 = new List<REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS>();

            List<REG_03000_ESTABELECIMENTO_FILIAL> Lista_REG_03000 = new List<REG_03000_ESTABELECIMENTO_FILIAL>();

            List<REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO> Lista_REG_03100 = new List<REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO>();

            List<REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A> Lista_REG_03110 = new List<REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A>();

            List<REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A> Lista_REG_03111 = new List<REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A>();

            List<REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A> Lista_REG_03112 = new List<REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A>();

            List<REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B> Lista_REG_03120 = new List<REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B>();

            List<REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B> Lista_REG_03121 = new List<REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B>();

            List<REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B> Lista_REG_03122 = new List<REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B>();

            List<REG_03122_LAYOUT_ATE_2017> Lista_REG_03122_LAYOUT_ATE_2017 = new List<REG_03122_LAYOUT_ATE_2017>();


            List<REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C> Lista_REG_03130 = new List<REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C>();

            List<REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C> Lista_REG_03131 = new List<REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C>();

            List<REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C> Lista_REG_03132 = new List<REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C>();

            List<REG_03500_FOLHA_SALARIOS> Lista_REG_03500 = new List<REG_03500_FOLHA_SALARIOS>();

            List<REG_04000_PERFIL> Lista_REG_04000 = new List<REG_04000_PERFIL>();

            List<REG_99999_ENCERRAMENTO_BLOCO> Lista_REG_99999 = new List<REG_99999_ENCERRAMENTO_BLOCO>();

            List<REG_ZZZZZ_ENCERRAMENTO_ARQUIVO_DIGITAL> Lista_REG_ZZZZZ = new List<REG_ZZZZZ_ENCERRAMENTO_ARQUIVO_DIGITAL>();


            #endregion


            if (File.Exists(pathArquivo))
            {
                // Obter lista de todas as prefeituras cadastradas

                ListaPefeituras = prefeituraDB.ObterListaPrefeitura();


                var arquivo = File.ReadAllLines(pathArquivo).ToList();

                bool inicioBloco = false;

                arquivo.ForEach(
                 linha =>
                 {
                     inicioBloco = true;

                     var dados = linha.Split('|');

                     var tipoRegistro = dados[0].ToString();


                     if (tipoRegistro.Equals(REG_AAAAA.TipoRegistro.Value))
                     {
                         var obj = new REG_AAAAA_ARQUIVO_DIGITAL();

                         AtribuirValoresMapeados(obj, dados, obj.GetType());

                         if (obj != null)
                         {
                             Lista_REG_AAAAA.Add(obj);
                         }

                     }

                     if (inicioBloco)
                     {
                         if (tipoRegistro.Equals(REG_00000.TipoRegistro.Value))
                         {

                             if (pathArquivo.Contains("PGDASD-2014") || pathArquivo.Contains("PGDASD-2015") || pathArquivo.Contains("PGDASD-2016"))
                             {
                                 var obj = new REG_00000_LAYOUT_ATE_2014();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_00000 = new REG_00000_CONTRIBUINTE_DADOS_APURACAO()
                                     {
                                         REG = obj.REG,
                                         Pgdasd_ID_Declaracao = obj.Pgdasd_ID_Declaracao,
                                         Pgdasd_Num_Recibo = obj.Pgdasd_Num_Recibo,
                                         Pgdasd_Num_Autenticacao = obj.Pgdasd_Num_Autenticacao,
                                         Pgdasd_Dt_Transmissao = obj.Pgdasd_Dt_Transmissao,
                                         Pgdasd_Versao = obj.Pgdasd_Versao,
                                         Cnpjmatriz = obj.Cnpjmatriz,
                                         Nome = obj.Nome,
                                         Cod_TOM = obj.Cod_TOM,
                                         Optante = obj.Optante,
                                         Abertura = obj.Abertura,
                                         PA = obj.PA,
                                         Rpa = obj.Rpa,
                                         R = obj.R,
                                         Operacao = obj.Operacao,
                                         Regime = obj.Regime,
                                         RpaC = obj.RpaC,
                                         Rpa_Int = obj.Rpa_Int,
                                         Rpa_Ext = obj.Rpa_Ext,

                                     };

                                     Lista_REG_00000.Add(objREG_00000);
                                 }
                             }

                             if (pathArquivo.Contains("PGDASD-2017"))
                             {
                                 var obj = new REG_00000_LAYOUT_ATE_2017();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_00000 = new REG_00000_CONTRIBUINTE_DADOS_APURACAO()
                                     {
                                         REG = obj.REG,
                                         Pgdasd_ID_Declaracao = obj.Pgdasd_ID_Declaracao,
                                         Pgdasd_Num_Recibo = obj.Pgdasd_Num_Recibo,
                                         Pgdasd_Num_Autenticacao = obj.Pgdasd_Num_Autenticacao,
                                         Pgdasd_Dt_Transmissao = obj.Pgdasd_Dt_Transmissao,
                                         Pgdasd_Versao = obj.Pgdasd_Versao,
                                         Cnpjmatriz = obj.Cnpjmatriz,
                                         Nome = obj.Nome,
                                         Cod_TOM = obj.Cod_TOM,
                                         Optante = obj.Optante,
                                         Abertura = obj.Abertura,
                                         PA = obj.PA,
                                         Rpa = obj.Rpa,
                                         R = obj.R,
                                         Operacao = obj.Operacao,
                                         Regime = obj.Regime,
                                         RpaC = obj.RpaC,
                                         Rpa_Int = obj.Rpa_Int,
                                         Rpa_Ext = obj.Rpa_Ext,
                                         Rpac_Int = obj.Rpac_Int,
                                         Rpac_Ext = obj.Rpac_Ext,
                                     };

                                     Lista_REG_00000.Add(objREG_00000);
                                 }
                             }



                             if (!(pathArquivo.Contains("PGDASD-2014") || pathArquivo.Contains("PGDASD-2015") || pathArquivo.Contains("PGDASD-2016")) && !pathArquivo.Contains("PGDASD-2017"))

                             {
                                 var obj = new REG_00000_CONTRIBUINTE_DADOS_APURACAO();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_00000.Add(obj);
                                 }
                             }

                         }

                         if (tipoRegistro.Equals(REG_00001.TipoRegistro.Value))
                         {

                             var obj = new REG_00001_PROCESSO_NAO_OPTANTE();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_00001.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_01000.TipoRegistro.Value))
                         {

                             if (!pathArquivo.Contains("PGDASD2018"))
                             {
                                 var obj = new REG_01000_LAYOUT_ATE_2017();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_01000 = new REG_01000_VALOR_APURADO_CALCULO()
                                     {
                                         REG = obj.REG,
                                         Dtvalcalc = obj.Dtvalcalc,
                                         Dtvenc = obj.Dtvenc,
                                         Juros = obj.Juros,
                                         Multa = obj.Multa,
                                         Nrpagto = obj.Nrpagto,
                                         Princ = obj.Princ,
                                         Tdevido = obj.Tdevido

                                     };

                                     Lista_REG_01000.Add(objREG_01000);
                                 }
                             }

                             else
                             {
                                 var obj = new REG_01000_VALOR_APURADO_CALCULO();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_01000.Add(obj);
                                 }
                             }




                         }

                         if (tipoRegistro.Equals(REG_01100.TipoRegistro.Value))
                         {

                             var obj = new REG_01100_PERFIL_DAS();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_01100.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_01500.TipoRegistro.Value))
                         {

                             var obj = new REG_01500_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_01500.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_01501.TipoRegistro.Value))
                         {

                             var obj = new REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_01501.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_01502.TipoRegistro.Value))
                         {

                             var obj = new REG_01502_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_EXTERNO();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_01502.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_02000.TipoRegistro.Value))
                         {

                             if (pathArquivo.Contains("PGDASD-2014") || pathArquivo.Contains("PGDASD-2015") || pathArquivo.Contains("PGDASD-2016"))

                             {
                                 var obj = new REG_02000_LAYOUT_ATE_2014();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_02000 = new REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS()
                                     {
                                         REG = obj.REG,
                                         rbt12 = obj.rbt12,
                                         Rbtaa = obj.Rbtaa,
                                         Rba = obj.Rba,
                                         rbt12o = obj.rbt12o,
                                         Rbtaao = obj.Rbtaao,
                                         ICMS = obj.ICMS,
                                         ISS = obj.ISS,
                                         Rbtaa_Int = obj.Rbtaa_Int,
                                         Rbtaa_Into = obj.Rbtaa_Into,
                                         Rbtaa_Ext = obj.Rbtaa_Ext,
                                         Rbtaa_Exto = obj.Rbtaa_Exto


                                     };

                                     Lista_REG_02000.Add(objREG_02000);
                                 }
                             }

                             else
                             {
                                 var obj = new REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_02000.Add(obj);
                                 }
                             }

                         }

                         if (tipoRegistro.Equals(REG_03000.TipoRegistro.Value))
                         {

                             if (pathArquivo.Contains("PGDASD-2014") || pathArquivo.Contains("PGDASD-2015") || pathArquivo.Contains("PGDASD-2016"))

                             {
                                 var obj = new REG_03000_LAYOUT_ATE_2014();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_03000 = new REG_03000_ESTABELECIMENTO_FILIAL()
                                     {
                                         REG = obj.REG,
                                         CNPJ = obj.CNPJ,
                                         Uf = obj.Uf,
                                         Cod_TOM = obj.Cod_TOM,
                                         Vltotal = obj.Vltotal,
                                         Sublimite = obj.Sublimite,
                                         Prex_int_sublimite = obj.Prex_int_sublimite,
                                         Prex_int_limite = obj.Prex_int_limite,
                                         Prex_ext_sublimite = obj.Prex_ext_sublimite,



                                     };

                                     Lista_REG_03000.Add(objREG_03000);
                                 }
                             }

                             else
                             {



                                 var obj = new REG_03000_ESTABELECIMENTO_FILIAL();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_03000.Add(obj);
                                 }
                             }

                         }

                         if (tipoRegistro.Equals(REG_03100.TipoRegistro.Value))
                         {

                             var obj = new REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03100.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03110.TipoRegistro.Value))
                         {

                             var obj = new REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03110.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03111.TipoRegistro.Value))
                         {

                             var obj = new REG_03111_VALOR_RECEITA_ISENCAO_FAIXA_A();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03111.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03112.TipoRegistro.Value))
                         {

                             if (pathArquivo.Contains("PGDASD-2017"))
                             {
                                 var obj = new REG_03112_LAYOUT_ATE_2017();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_03112 = new REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A()
                                     {
                                         Aliqapur = obj.Aliqapur,
                                         Aliquota_apurada_COFINS = obj.Aliquota_apurada_COFINS,
                                         Aliquota_apurada_CSLL = obj.Aliquota_apurada_CSLL,
                                         Aliquota_apurada_ICMS = obj.Aliquota_apurada_ICMS,
                                         Aliquota_apurada_IRPJ = obj.Aliquota_apurada_IRPJ,
                                         Aliquota_apurada_ISS = obj.Aliquota_apurada_ISS,
                                         Aliquota_apurada_PIS = obj.Aliquota_apurada_PIS,
                                         Alíquota_apurada_INSS = obj.Alíquota_apurada_INSS,
                                         Alíquota_apurada_IPI = obj.Alíquota_apurada_IPI,
                                         Diferenca = obj.Diferenca,
                                         Maiortributo = obj.Maiortributo,
                                         Red = obj.Red,
                                         REG = obj.REG,
                                         Valor = obj.Valor,
                                         Valor_apurado_COFINS = obj.Valor_apurado_COFINS,
                                         Valor_apurado_CSLL = obj.Valor_apurado_CSLL,
                                         Valor_apurado_ICMS = obj.Valor_apurado_ICMS,
                                         Valor_apurado_INSS = obj.Valor_apurado_INSS,
                                         Valor_apurado_IPI = obj.Valor_apurado_IPI,
                                         Valor_apurado_IRPJ = obj.Valor_apurado_IRPJ,
                                         Valor_apurado_ISS = obj.Valor_apurado_ISS,
                                         Valor_apurado_PIS = obj.Valor_apurado_PIS,
                                         Vlimposto = obj.Vlimposto

                                     };

                                     Lista_REG_03112.Add(objREG_03112);
                                 }
                             }

                             else
                             {


                                 var obj = new REG_03112_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_03112.Add(obj);
                                 }
                             }

                         }

                         if (tipoRegistro.Equals(REG_03120.TipoRegistro.Value))
                         {

                             var obj = new REG_03120_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03120.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03121.TipoRegistro.Value))
                         {

                             var obj = new REG_03121_VALOR_RECEITA_ISENCAO_FAIXA_B();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03121.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03122.TipoRegistro.Value))
                         {

                             if (pathArquivo.Contains("PGDASD-2017"))
                             {
                                 var obj = new REG_03122_LAYOUT_ATE_2017();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     var objREG_03122 = new REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B()
                                     {
                                         Aliqapur = obj.Aliqapur,
                                         Aliquota_apurada_COFINS = obj.Aliquota_apurada_COFINS,
                                         Valor_apurado_PIS = obj.Valor_apurado_PIS,
                                         Valor_apurado_ISS = obj.Valor_apurado_ISS,
                                         Valor_apurado_IRPJ = obj.Valor_apurado_IRPJ,
                                         Valor_apurado_IPI = obj.Valor_apurado_IPI,
                                         Valor_apurado_INSS = obj.Valor_apurado_INSS,
                                         Valor_apurado_ICMS = obj.Valor_apurado_ICMS,
                                         Valor_apurado_CSLL = obj.Valor_apurado_CSLL,
                                         Aliquota_apurada_CSLL = obj.Aliquota_apurada_CSLL,
                                         Aliquota_apurada_ICMS = obj.Aliquota_apurada_ICMS,
                                         Aliquota_apurada_IRPJ = obj.Aliquota_apurada_IRPJ,
                                         Aliquota_apurada_ISS = obj.Aliquota_apurada_ISS,
                                         Aliquota_apurada_PIS = obj.Aliquota_apurada_PIS,
                                         Alíquota_apurada_INSS = obj.Alíquota_apurada_INSS,
                                         Alíquota_apurada_IPI = obj.Alíquota_apurada_IPI,
                                         REG = obj.REG,
                                         Valor_apurado_COFINS = obj.Valor_apurado_COFINS,
                                         Red = 0
                                     };

                                     Lista_REG_03122_LAYOUT_ATE_2017.Add(obj);
                                 }
                             }

                             else
                             {
                                 var obj = new REG_03122_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_B();

                                 AtribuirValoresMapeados(obj, dados, obj.GetType());

                                 if (obj != null)
                                 {
                                     Lista_REG_03122.Add(obj);
                                 }
                             }

                         }

                         if (tipoRegistro.Equals(REG_03130.TipoRegistro.Value))
                         {

                             var obj = new REG_03130_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03130.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03131.TipoRegistro.Value))
                         {

                             var obj = new REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03131.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03132.TipoRegistro.Value))
                         {

                             var obj = new REG_03132_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_C();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03132.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_03500.TipoRegistro.Value))
                         {

                             var obj = new REG_03500_FOLHA_SALARIOS();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_03500.Add(obj);
                             }

                         }

                         if (tipoRegistro.Equals(REG_04000.TipoRegistro.Value))
                         {

                             var obj = new REG_04000_PERFIL();

                             AtribuirValoresMapeados(obj, dados, obj.GetType());

                             if (obj != null)
                             {
                                 Lista_REG_04000.Add(obj);
                             }

                         }


                     }

                     if (tipoRegistro.Equals(REG_99999.TipoRegistro.Value))
                     {
                         int COD_TOM = 0;
                         decimal Pgdasd_ID_Declaracao = 0;

                         inicioBloco = false;

                         var obj = new REG_99999_ENCERRAMENTO_BLOCO();

                         AtribuirValoresMapeados(obj, dados, obj.GetType());

                         if (obj != null)
                         {
                             Lista_REG_99999.Add(obj);
                         }

                         ListaPefeituras.ForEach(item =>
                         {

                             Lista_REG_00000.ForEach(Item_REG_00000 =>
                             {

                                 if (item.ID_PREFEITURA.ToString().Equals(Item_REG_00000.Cod_TOM.ToString()))
                                 {

                                     COD_TOM = Convert.ToInt32(Item_REG_00000.Cod_TOM);
                                     Pgdasd_ID_Declaracao = Convert.ToDecimal(Item_REG_00000.Pgdasd_ID_Declaracao);

                                     Lista_REG_00000_AUX.Add(Item_REG_00000);
                                 }

                             });
                         });


                         if (Lista_REG_00000_AUX != null && Lista_REG_00000_AUX.Count > 0)
                         {


                             // Inserir na base o xml com os dados

                             bool retorno = simplesNacionaDB.InserirDeclaracaoSimplesNacional(COD_TOM,
                                                                                              Pgdasd_ID_Declaracao,
                                                                                              Lista_REG_AAAAA,
                                                                                              Lista_REG_00000,
                                                                                              Lista_REG_00001,
                                                                                              Lista_REG_01000,
                                                                                              Lista_REG_01100,
                                                                                              Lista_REG_01500,
                                                                                              Lista_REG_01501,
                                                                                              Lista_REG_01502,
                                                                                              Lista_REG_02000,
                                                                                              Lista_REG_03000,
                                                                                              Lista_REG_03100,
                                                                                              Lista_REG_03110,
                                                                                              Lista_REG_03111,
                                                                                              Lista_REG_03112,
                                                                                              Lista_REG_03120,
                                                                                              Lista_REG_03121,
                                                                                              Lista_REG_03122,
                                                                                              Lista_REG_03122_LAYOUT_ATE_2017,
                                                                                              Lista_REG_03130,
                                                                                              Lista_REG_03131,
                                                                                              Lista_REG_03132,
                                                                                              Lista_REG_03500,
                                                                                              Lista_REG_04000,
                                                                                              Lista_REG_99999);


                             Lista_REG_00000_AUX.Clear();

                             Lista_REG_00000.Clear();

                             Lista_REG_00001.Clear();

                             Lista_REG_01000.Clear();

                             Lista_REG_01100.Clear();

                             Lista_REG_01500.Clear();

                             Lista_REG_01501.Clear();

                             Lista_REG_01502.Clear();

                             Lista_REG_02000.Clear();

                             Lista_REG_03000.Clear();

                             Lista_REG_03100.Clear();

                             Lista_REG_03110.Clear();

                             Lista_REG_03111.Clear();

                             Lista_REG_03112.Clear();

                             Lista_REG_03120.Clear();

                             Lista_REG_03121.Clear();

                             Lista_REG_03122.Clear();

                             Lista_REG_03122_LAYOUT_ATE_2017.Clear();

                             Lista_REG_03130.Clear();

                             Lista_REG_03131.Clear();

                             Lista_REG_03132.Clear();

                             Lista_REG_03500.Clear();

                             Lista_REG_04000.Clear();

                             Lista_REG_99999.Clear();

                         }
                         else
                         {
                             Lista_REG_00000.Clear();

                             Lista_REG_00001.Clear();

                             Lista_REG_01000.Clear();

                             Lista_REG_01100.Clear();

                             Lista_REG_01500.Clear();

                             Lista_REG_01501.Clear();

                             Lista_REG_01502.Clear();

                             Lista_REG_02000.Clear();

                             Lista_REG_03000.Clear();

                             Lista_REG_03100.Clear();

                             Lista_REG_03110.Clear();

                             Lista_REG_03111.Clear();

                             Lista_REG_03112.Clear();

                             Lista_REG_03120.Clear();

                             Lista_REG_03121.Clear();

                             Lista_REG_03122.Clear();

                             Lista_REG_03122_LAYOUT_ATE_2017.Clear();

                             Lista_REG_03130.Clear();

                             Lista_REG_03131.Clear();

                             Lista_REG_03132.Clear();

                             Lista_REG_03500.Clear();

                             Lista_REG_04000.Clear();

                             Lista_REG_99999.Clear();
                         }


                     }

                     if (tipoRegistro.Equals(REG_ZZZZZ.TipoRegistro.Value))
                     {

                         inicioBloco = false;

                         var obj = new REG_ZZZZZ_ENCERRAMENTO_ARQUIVO_DIGITAL();

                         AtribuirValoresMapeados(obj, dados, obj.GetType());

                         if (obj != null)
                         {
                             Lista_REG_ZZZZZ.Add(obj);
                         }

                     }

                 });




            }


            return true;


        }

        private void AtribuirValoresMapeados(object obj, string[] dados, Type type)
        {
            try
            {
                var ContadorPropriedades = type.GetProperties().Count();


                int controleLoop = 0;

                List<PropertyInfo> campos = obj.GetType().GetProperties().Where(p => p.GetCustomAttribute(typeof(CampoArquivoPGDASD)) != null).ToList();
                campos = campos.OrderBy(c => c.GetCustomAttribute<CampoArquivoPGDASD>().Ordem).ToList();

                foreach (PropertyInfo propertyInfo in campos)
                {
                    for (int i = controleLoop; i < ContadorPropriedades; i++)
                    {
                        var valor = TratarValor(dados[controleLoop], propertyInfo);
                        propertyInfo.SetValue(obj, valor);
                    }

                    controleLoop++;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected object TratarValor(object valor, PropertyInfo propriedade)
        {
            try
            {
                if (propriedade.PropertyType == typeof(Int32))
                {
                    if (!valor.ToString().Equals(string.Empty))
                    {
                        return Convert.ToInt32(valor);
                    }

                    else
                    {
                        valor = (int)0;
                    }
                }

                if (propriedade.PropertyType == typeof(Int64))
                {
                    if (!valor.ToString().Equals(string.Empty))
                    {
                        return Convert.ToInt64(valor);
                    }

                    else
                    {
                        valor = (int)0;
                    }
                }

                if (propriedade.PropertyType == typeof(Decimal))
                {
                    if (!valor.ToString().Equals(string.Empty))
                    {
                        return Convert.ToDecimal(valor);
                    }

                    else
                    {
                        valor = (decimal)0.0;
                    }
                }


                return valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

