using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Informações de receitas brutas de períodos anteriores à opção no mercado interno.
    /// Nível hierárquico – 2
    /// Ocorrência – zero a 23, uma ocorrência por linha
    /// 
    /// </summary>
    public class REG_01501_RECEITAS_BRUTAS_PERIODO_ANTERIORES_OPCAO_MERCADO_INTERNO
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "01501"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Período de apuração (AAAAMM) para coleta da Receita Bruta do Simples Nacional
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string Rbsn_Int_PA { get; set; }

        /// <summary>
        /// Valor da receita bruta do Simples Nacional no Mercado Interno
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Rbsn_Int_valor { get; set; }

    }
}
