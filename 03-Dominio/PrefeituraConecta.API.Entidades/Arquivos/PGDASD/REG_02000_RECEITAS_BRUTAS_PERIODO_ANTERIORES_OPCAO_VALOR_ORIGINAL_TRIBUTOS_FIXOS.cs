using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Receitas brutas de períodos anteriores, valor original e tributos fixos.
    /// nunca será informado valor 0,00 de ICMS e ISS – ou o campo ficará em branco, ou será informado valor diferente de 0,00
    /// Nível hierárquico – 2
    /// Ocorrência - 1:1
    /// 
    /// </summary>
    public class REG_02000_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_VALOR_ORIGINAL_TRIBUTOS_FIXOS
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "02000"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public decimal rbt12 { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Rbtaa { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public decimal Rba { get; set; }

        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses original.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal rbt12o { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior original
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public decimal Rbtaao { get; set; }

        /// <summary>
        /// Valor fixo de ICMS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public decimal ICMS { get; set; }

        /// <summary>
        /// Valor fixo de ISS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public decimal ISS { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior no mercado interno. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public decimal Rbtaa_Int { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior original no mercado interno.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 10)]
        public decimal Rbtaa_Into { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior no mercado externo. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 11)]
        public decimal Rbtaa_Ext { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário anterior original no mercado externo.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 12)]
        public decimal Rbtaa_Exto { get; set; }

        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses no mercado interno. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 13)]
        public decimal Rbt12_Int { get; set; }


        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses original no mercado interno. 
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 14)]
        public decimal Rbt12_Into { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário no mercado interno
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 15)]
        public decimal Rba_Int { get; set; }

        /// <summary>
        /// Valor da receita bruta do ano-calendário no mercado externo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 16)]
        public decimal Rba_Ext { get; set; }

        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses no mercado externo. (pode ser proporcional à data da abertura da empresa)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 17)]
        public decimal Rbt12_Ext { get; set; }

        /// <summary>
        /// Valor da receita bruta dos últimos 12 meses original no mercado externo. 
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 18)]
        public decimal Rbt12_Exto { get; set; }



    }
}
