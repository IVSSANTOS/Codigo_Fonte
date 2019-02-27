using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Entidades
{
    public class Declaracoes
    {
        public decimal EMPRESAS { get; set; }
        public decimal TRANSMITIDAS { get; set; }
        public decimal RECEITAS_DECLARADAS_ISSQN { get; set; }
        public decimal RECEITAS_DECLARADAS_ICMS { get; set; }
        public decimal SERVICOS_SEM_RETENCAO { get; set; }
        public decimal SERVICOS_COM_RETENCAO { get; set; }
        public decimal SERVICOS_OUTROS_MUNICIPIOS { get; set; }
        public decimal SERVICOS_LOCACAO { get; set; }
        public decimal SERVICOS_CONTABILIDADE { get; set; }
        public decimal SERVICOS_EXTERIOR { get; set; }
        public decimal COMERCIO_MERCADO_INTERNO { get; set; }
        public decimal COMERCIO_EXTERIOR { get; set; }
    }
}
