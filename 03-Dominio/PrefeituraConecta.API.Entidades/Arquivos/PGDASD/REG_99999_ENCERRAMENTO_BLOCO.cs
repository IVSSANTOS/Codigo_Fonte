using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Encerramento do bloco 00000.
    /// deve conter o total de linhas do bloco, inclusive as linhas 00000 e 99999
    /// Registro obrigatório
    /// Nível hierárquico – 3
    /// Ocorrência - um por registro 00000
    /// 
    /// </summary>
    public class REG_99999_ENCERRAMENTO_BLOCO
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "99999"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Quantidade total de linhas do REGISTRO 00000
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public int QTD_LIN_0 { get; set; }
    }
}
