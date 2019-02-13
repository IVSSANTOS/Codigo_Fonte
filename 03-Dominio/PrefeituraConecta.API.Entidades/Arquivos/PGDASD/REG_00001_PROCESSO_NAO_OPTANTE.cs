using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Informações sobre o processo para não optante.
    /// Nível hierárquico – 2
    /// Ocorrência – 0:1
    /// Caso o contribuinte seja não optante, o registro será obrigatório
    /// </summary>

    public class REG_00001_PROCESSO_NAO_OPTANTE
    {

        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        
        public int IdContribuinte { get; set; }

        /// <summary>
        /// Texto fixo contendo "00001"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Esfera administrativa do processo. (1 - Federal, 2 – Estadual, 3 – Distrital e 4 – Municipal)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string admtrib { get; set; }

        /// <summary>
        /// Sigla da Unidade federativa que está protocolado o processo.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public string uf { get; set; }

        /// <summary>
        /// Descrição do município onde está protocolado o processo.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public string munic { get; set; }

        /// <summary>
        /// Código do município onde está protocolado o processo.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public string codmunic { get; set; }

        /// <summary>
        /// Número do processo.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public string numproc { get; set; }


    }
}
