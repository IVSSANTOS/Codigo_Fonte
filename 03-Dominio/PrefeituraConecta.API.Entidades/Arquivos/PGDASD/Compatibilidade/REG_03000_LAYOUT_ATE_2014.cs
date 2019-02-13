using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade
{
    public class REG_03000_LAYOUT_ATE_2014
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03000"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// CNPJ do estabelecimento filial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Sigla da UF do estabelecimento filial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public string Uf { get; set; }

        /// <summary>
        /// Código do município do estabelecimento filial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public string Cod_TOM { get; set; }

        /// <summary>
        /// TValor total da receita para a filial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal Vltotal { get; set; }

        /// <summary>
        /// Sublimite Estadual para o estabelecimento filial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public decimal Sublimite { get; set; }

        /// <summary>
        /// Percentual que excede o sublimite no mercado interno e está dentro do limite.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public decimal Prex_int_sublimite { get; set; }

        /// <summary>
        /// Percentual que excede o limite no mercado interno.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public decimal Prex_int_limite { get; set; }

        /// <summary>
        /// Percentual que excede o sublimite no mercado externo e está dentro do limite.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public decimal Prex_ext_sublimite { get; set; }

       
    }
}
