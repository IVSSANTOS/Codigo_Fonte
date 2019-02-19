using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Entidades
{
    public class DECLARACOES_TRANSM_INCIDENCIA_ISSQN
    {
        public int ID_CONTRIBUINTE { get; set; }

        public long CNPJMATRIZ { get; set; }

        public string NOME { get; set; }

        public decimal RPA { get; set; }

        public decimal SEM_RETENCAO { get; set; }

        public decimal COM_RETENCAO { get; set; }

        public decimal OUTROS_M { get; set; }

        public decimal CONTABILIDADE { get; set; }

        public int ID_PREFEITURA { get; set; }

        public decimal LOCACAO { get; set; }

        public decimal EXTERIOR { get; set; }
    }
}
