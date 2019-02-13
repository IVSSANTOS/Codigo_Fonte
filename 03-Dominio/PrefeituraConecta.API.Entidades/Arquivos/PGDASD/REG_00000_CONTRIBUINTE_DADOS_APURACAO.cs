using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos.PGDASD
{
    /// <summary>
    /// Identificação do contribustringe e dados da apuração
    /// Registro obrigatório
    /// Nível hierárquico – 1
    /// Ocorrência – 1:N
    /// </summary>
    public class REG_00000_CONTRIBUINTE_DADOS_APURACAO
    {

        /// <summary>
        /// Texto fixo contendo "00000"
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 1)]
        public string REG { get; set; }

        /// <summary>
        /// Pgdas-D – ID da Declaração. Formato: CNPJ Básico + PA (AAAAMM) + Número Sequencial de 001 até 999
        /// </summary>

        [CampoArquivoPGDASD(_ordem: 2)]
        public string Pgdasd_ID_Declaracao { get; set; }

        /// <summary>
        /// Pgdas-D – Número do Recibo de Entrega da Transmissão da Apuração
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 3)]
        public string Pgdasd_Num_Recibo { get; set; }

        /// <summary>
        /// Pgdas-D – Número da Autenticação da declaração transmitida Formato: numérico de 20 posições, sem separadores
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 4)]
        public string Pgdasd_Num_Autenticacao { get; set; }

        /// <summary>
        /// Pgdas-D – Data e hora da Transmissão da Declaração. Formato: aaaammddhhmmss. Hora no formato 24 horas
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 5)]
        public string Pgdasd_Dt_Transmissao { get; set; }

        /// <summary>
        /// Versão em que a apuração foi transmitida.
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 6)]
        public string Pgdasd_Versao { get; set; }

        /// <summary>
        /// Número indicador do CNPJ do estabelecimento matriz
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 7)]
        public string Cnpjmatriz { get; set; }


        /// <summary>
        /// Razão Social do estabelecimento matriz
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 8)]
        public string Nome { get; set; }


        /// <summary>
        /// Código do município do estabelecimento matriz
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 9)]
        public string Cod_TOM { get; set; }


        /// <summary>
        /// S= Optante; N = Não optante do Simples Nacional 
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 10)]
        public string Optante { get; set; }


        /// <summary>
        /// Data de abertura da empresa (AAAAMMDD)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 11)]
        public string Abertura { get; set; }

        /// <summary>
        /// Período de apuração (AAAAMM)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 12)]
        public string PA { get; set; }

        /// <summary>
        /// Receita bruta do período de apuração no Regime Competência (string + ext)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 13)]
        public decimal Rpa { get; set; }

        /// <summary>
        /// Razão da folha salarial
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 14)]
        public decimal R { get; set; }

        /// <summary>
        /// Informa se se trata de apuração (A) ou retificação (R) 
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 15)]
        public string Operacao { get; set; }


        /// <summary>
        /// Informa se a empresa utiliza o regime de competência (0) ou caixa (1)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 16)]
        public string Regime { get; set; }


        /// <summary>
        /// Receita bruta do período de apuração no Regime Caixa (string + ext)
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 17)]
        public decimal RpaC { get; set; }

        /// <summary>
        /// Receita bruta do período de apuração no Regime Competência stringerna
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 18)]
        public decimal Rpa_Int { get; set; }

        /// <summary>
        /// Receita bruta do período de apuração no Regime Competência Externa
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 19)]
        public decimal Rpa_Ext { get; set; }

        /// <summary>
        /// Receita bruta do período de apuração no Regime Caixa stringerna
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 20)]
        public decimal Rpac_Int { get; set; }

        /// <summary>
        /// Receita bruta do período de apuração no Regime Caixa Externa
        /// </summary>
        [CampoArquivoPGDASD(_ordem: 21)]
        public decimal Rpac_Ext { get; set; }


    }
}
