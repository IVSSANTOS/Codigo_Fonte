using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Entidades
{
    public class DECLARACOES_TRANSM_INCIDENCIA_ISSQN_ICMS
    {
        public int ID_CONTRIBUINTE { get; set; }

      
        public long CNPJMATRIZ { get; set; }

       
        public string NOME { get; set; }

       
        public decimal RPA { get; set; }

        public int ID_PREFEITURA { get; set; }

        
        public decimal VALOR_APURADO_DE_ISS { get; set; }

       
        public decimal VALOR_APURADO_DE_ICMS { get; set; }
    }
}
