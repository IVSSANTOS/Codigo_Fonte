using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{
    /// <summary>
    /// Informações referentes à folha de salários.
    /// Nível hierárquico – 2
    /// Ocorrência – 0:13 – zero a 13 ocorrências, uma por linha.
    /// Existem 13 ocorrências quando o RBT12 é zero e as folhas de salário dos últimos 12 meses também possuem valor zero, situação em que o fator “r” é calculado com a fórmula “Folha de Salário do PA/Receita do PA”. Nessa situação, é necessário informar também a folha de salário do próprio PA.
    /// </summary>
    public class REG_03500_FOLHA_SALARIOS
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03500"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Período de apuração (AAAAMM) em que houver a coleta da Folha de Salário
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public decimal fssn_PA { get; set; }


        /// <summary>
        /// Valor pago de Folha de Salário para um determinado PA
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal fssn_valor { get; set; }


    }
}
