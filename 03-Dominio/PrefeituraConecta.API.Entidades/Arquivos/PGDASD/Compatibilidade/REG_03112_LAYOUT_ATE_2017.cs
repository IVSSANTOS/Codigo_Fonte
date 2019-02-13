using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD.Compatibilidade
{
    public class REG_03112_LAYOUT_ATE_2017
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03112"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }


        /// <summary>
        /// Valor da receita para cada atividade
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public decimal Valor { get; set; }

        /// <summary>
        /// Percentual de redução aplicado ao ICMS/ISS para o valor de receita informado em 02
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Red { get; set; }

        /// <summary>
        /// Somatório das alíquotas apuradas de todos os tributos de determinada atividade
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public decimal Aliqapur { get; set; }


        /// <summary>
        /// Valor do imposto (valor x aliqapur) (total)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal Vlimposto { get; set; }

        /// <summary>
        /// Alíquota apurada de COFINS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public decimal Aliquota_apurada_COFINS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public decimal Valor_apurado_COFINS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public decimal Aliquota_apurada_CSLL { get; set; }

        /// <summary>
        /// Valor_calculado_referente_tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public decimal Valor_apurado_CSLL { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 10)]
        public decimal Aliquota_apurada_ICMS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 11)]
        public decimal Valor_apurado_ICMS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 12)]
        public decimal Alíquota_apurada_INSS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 13)]
        public decimal Valor_apurado_INSS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 14)]
        public decimal Alíquota_apurada_IPI { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 15)]
        public decimal Valor_apurado_IPI { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 16)]
        public decimal Aliquota_apurada_IRPJ { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributos
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 17)]
        public decimal Valor_apurado_IRPJ { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 18)]
        public decimal Aliquota_apurada_ISS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 19)]
        public decimal Valor_apurado_ISS { get; set; }


        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 20)]
        public decimal Aliquota_apurada_PIS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 21)]
        public decimal Valor_apurado_PIS { get; set; }

        [CampoArquivoPGDASD(_ordem: 22)]
        public decimal Diferenca { get; set; }

        [CampoArquivoPGDASD(_ordem: 23)]
        public decimal Maiortributo { get; set; }
    }
}
