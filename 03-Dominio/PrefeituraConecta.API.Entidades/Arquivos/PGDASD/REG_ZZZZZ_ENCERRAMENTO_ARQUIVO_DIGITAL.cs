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
    public class REG_ZZZZZ_ENCERRAMENTO_ARQUIVO_DIGITAL
    {

        /// <summary>
        /// Texto fixo contendo "99999"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Quantidade de registros do arquivo digital, desde o registro AAAAA até o registro ZZZZZ. 
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public int QTD_LIN_REG_ZZZZZ { get; set; }
    }
}
