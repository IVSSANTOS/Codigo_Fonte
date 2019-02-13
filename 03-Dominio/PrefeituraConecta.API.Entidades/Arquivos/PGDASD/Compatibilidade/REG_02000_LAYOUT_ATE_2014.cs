using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade
{
    public class REG_02000_LAYOUT_ATE_2014
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

        
    }
}
