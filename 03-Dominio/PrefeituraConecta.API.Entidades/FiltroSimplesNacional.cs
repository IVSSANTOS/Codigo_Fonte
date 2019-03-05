using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Entidades
{
    public class FiltroSimplesNacional
    {
        public int ID_CONSULTA { get; set; }

        public int ID_PREFEITURA { get; set; }

        public int ID_USUARIO { get; set; }

        public string Consulta { get; set; }
               
        public string ConsolidadoPor { get; set; }
              
        public string TipoEmpresa { get; set; }
              
        public string TipoDeclaracao { get; set; }
               
        public string Regime { get; set; }
             
        public int PeriodoApuracaoDe { get; set; }
              
        public int PeriodoApuracaoAte { get; set; }
               
        public int CNPJ { get; set; }
    }
}
