using PrefeituraConecta.API.Dados;
using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Negocio
{
    public class VALOR_APURADO_EMPRESAS_BS
    {
        VALOR_APURADO_EMPRESAS_DB db = new VALOR_APURADO_EMPRESAS_DB();

        public List<VALOR_APURADO_EMPRESAS> ObterLista()
        {
            try
            {
                return db.ObterLista();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
