using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{
    /// <summary>
    /// Informações de cada atividade selecionada para cada estabelecimento.
    /// Nível hierárquico – 3
    /// Ocorrência – 0:43 – de 0 (quando nenhum dado é informado para a filial) até 43.
    /// 
    /// </summary>

    public class REG_03100_ATIVIDADE_SELECIONADA_ESTABELECIMENTO
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "03110"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Tipo de atividade do Simples Nacional (01 a 43)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string Tipo { get; set; }

        /// <summary>
        /// Valor total da receita para a atividade selecionada
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal Vltotal { get; set; }
    }
}
