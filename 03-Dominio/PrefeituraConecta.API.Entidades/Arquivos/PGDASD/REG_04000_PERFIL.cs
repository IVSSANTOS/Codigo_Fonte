using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{

    /// <summary>
    /// Informações do perfil
    /// Nível hierárquico – 2
    /// Ocorrência – N:1
    /// Quando não há geração de DAS, o registro não constará no arquivo.
    /// o REG_04000 não é utilizado no layout de 2018
    /// Criado para compatibilidade de carga de arquivos com layout anterior a 2018
    /// </summary>

    public class REG_04000_PERFIL
    {
        /// <summary>
        /// Indentificador do contribuinte (REG_00000)
        /// </summary>
        public int IdContribuinte { get; set; }


        /// <summary>
        /// Texto fixo contendo "01100"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Código de receita do principal
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 2)]
        public string codrecp { get; set; }

        /// <summary>
        /// Valor do principal
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public decimal valorprinc { get; set; }


        /// <summary>
        /// Código de receita da multa
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public string codrecm { get; set; }

        /// <summary>
        /// Valor da multa
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public decimal valorm { get; set; }

        /// <summary>
        /// Código de receita dos juros
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public string codrecj { get; set; }

        /// <summary>
        /// Valor dos juros
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public decimal valorj { get; set; }


        /// <summary>
        /// UF no caso de ICMS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public string uf { get; set; }


        /// <summary>
        /// Código do município no caso de ISS
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public string codmunic { get; set; }
    }
}
