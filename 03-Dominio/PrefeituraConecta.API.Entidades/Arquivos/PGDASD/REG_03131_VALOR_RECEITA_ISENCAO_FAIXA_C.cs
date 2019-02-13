using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{
    /// <summary>
    /// Informação do valor de receita com isenção (faixa C).
    /// Nível hierárquico – 5
    /// Ocorrência – 0:N
    /// 
    /// </summary>
    /// 
    public class REG_03131_VALOR_RECEITA_ISENCAO_FAIXA_C
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03131"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }


        /// <summary>
        /// Somatório das alíquotas apuradas de todos os tributos de determinada atividade
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public decimal Aliqapur { get; set; }


        /// <summary>
        /// Alíquota apurada de COFINS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Aliquota_apurada_COFINS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public decimal Valor_apurado_COFINS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal Aliquota_apurada_CSLL { get; set; }

        /// <summary>
        /// Valor_calculado_referente_tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public decimal Valor_apurado_CSLL { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public decimal Aliquota_apurada_ICMS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public decimal Valor_apurado_ICMS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public decimal Alíquota_apurada_INSS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 10)]
        public decimal Valor_apurado_INSS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 11)]
        public decimal Alíquota_apurada_IPI { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 12)]
        public decimal Valor_apurado_IPI { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 13)]
        public decimal Aliquota_apurada_IRPJ { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributos
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 14)]
        public decimal Valor_apurado_IRPJ { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 15)]
        public decimal Aliquota_apurada_ISS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 16)]
        public decimal Valor_apurado_ISS { get; set; }


        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 17)]
        public decimal Aliquota_apurada_PIS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 18)]
        public decimal Valor_apurado_PIS { get; set; }
    }
}
