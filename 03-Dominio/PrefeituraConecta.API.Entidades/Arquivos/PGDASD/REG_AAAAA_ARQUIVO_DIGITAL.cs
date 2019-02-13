using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Abertura do arquivo digital.
    ///Registro obrigatório
    ///Nível hierárquico – 0
    ///Ocorrência – um por arquivo
    /// </summary>
    

    public class REG_AAAAA_ARQUIVO_DIGITAL
    {

        /// <summary>
        /// Texto fixo contendo "AAAAA"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG_ABERTURA { get; set; }


        /// <summary>
        /// Código da versão do leiaute correspondente ao Manual de Orientação do PGDAS2012
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string COD_VER { get; set; }


        /// <summary>
        /// Data inicial das informações contidas no arquivo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public string DT_INI { get; set; }

        /// <summary>
        /// Data final das informações contidas no arquivo
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public string DT_FIN { get; set; }

    }
}
