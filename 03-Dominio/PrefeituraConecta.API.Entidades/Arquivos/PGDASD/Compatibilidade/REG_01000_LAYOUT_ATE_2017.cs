using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade
{
    public class REG_01000_LAYOUT_ATE_2017
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "01000"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Número da guia DAS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string Nrpagto { get; set; }


        /// <summary>
        /// Valor principal
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Princ { get; set; }


        /// <summary>
        /// Valor da multa
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public decimal Multa { get; set; }


        /// <summary>
        /// Valor dos juros
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal Juros { get; set; }


        /// <summary>
        /// Valor total devido
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public decimal Tdevido { get; set; }


        /// <summary>
        /// Data do vencimento (AAAAMMDD)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public string Dtvenc { get; set; }

        /// <summary>
        /// Data da validade do cálculo (AAAAMMDD)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public string Dtvalcalc { get; set; }

        /// <summary>
        /// Data e hora da emissão do DAS. Formato: aaaammddhhmmss. Hora no formato 24 horas
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public string Vdas { get; set; }
    }
}
