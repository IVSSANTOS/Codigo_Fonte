using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{
    /// <summary>
    /// Informações detalhadas do valor da receita por atividade com percentual (faixa A).
    /// Nível hierárquico – 4
    /// Ocorrência – 1:N
    /// 
    /// </summary>
    /// 
    public class REG_03110_VALOR_RECEITA_ATIVIDADE_PERCENTUAL_FAIXA_A
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03110"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public int REG { get; set; }

        /// <summary>
        /// sigla da UF onde existiu receita para a atividade – deve ser informada ou deixada em branco (ex: || ou |SP|)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string UF { get; set; }

        /// <summary>
        /// código do município onde existiu receita para a atividade – deve ser informada ou deixada em branco (ex: || ou |7107|)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public string Cod_TOM { get; set; }

        /// <summary>
        /// Valor da receita para cada atividade
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public decimal Valor { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// 08 – substituição tributária
        /// 09 – tributação monofásica
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public int COFINS { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public int CSLL { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 01 - imunidade
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// 04 – isenção
        /// 05 – redução
        /// 06 – isenção de cesta básica
        /// 07 – redução de cesta básica
        /// 08 – substituição tributária
        /// 10 – antecipação com encerramento de tributação
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public int ICMS { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public int INSS { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 01 - imunidade
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// 08 – substituição tributária
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public int IPI { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 10)]
        public int IRPJ { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 01 - imunidade
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// 04 – isenção
        /// 05 – redução
        /// 11 – retenção
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 11)]
        public int ISS { get; set; }

        /// <summary>
        /// 00 – não foi informado
        /// 01 - imunidade
        /// 02 – exigibilidade suspensa
        /// 03 – lançamento de ofício
        /// 08 – substituição tributária
        /// 09 – tributação monofásica
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 12)]
        public int PIS { get; set; }

        /// <summary>
        /// Somatório das alíquotas apuradas de todos os tributos de determinada atividade
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 13)]
        public decimal Aliqapur { get; set; }

        /// <summary>
        /// Valor do imposto (valor x aliqapur) (total)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 14)]
        public decimal Vlimposto { get; set; }

        /// <summary>
        /// Alíquota apurada de COFINS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 15)]
        public decimal Aliquota_apurada_COFINS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 16)]
        public decimal Valor_apurado_COFINS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 17)]
        public decimal Aliquota_apurada_CSLL { get; set; }

        /// <summary>
        /// Valor_calculado_referente_tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 18)]
        public decimal Valor_apurado_CSLL { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 19)]
        public decimal Aliquota_apurada_ICMS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 20)]
        public decimal Valor_apurado_ICMS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 21)]
        public decimal Aliquota_apurada_INSS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 22)]
        public decimal Valor_apurado_INSS { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 23)]
        public decimal Aliquota_apurada_IPI { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 24)]
        public decimal Valor_apurado_IPI { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 25)]
        public decimal Aliquota_apurada_IRPJ { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributos
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 26)]
        public decimal Valor_apurado_IRPJ { get; set; }

        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 27)]
        public decimal Aliquota_apurada_ISS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 28)]
        public decimal Valor_apurado_ISS { get; set; }


        /// <summary>
        /// Porcentagem da alíquota apurada para o tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 29)]
        public decimal Aliquota_apurada_PIS { get; set; }

        /// <summary>
        /// Valor calculado referente ao tributo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 30)]
        public decimal Valor_apurado_PIS { get; set; }


    }
}
