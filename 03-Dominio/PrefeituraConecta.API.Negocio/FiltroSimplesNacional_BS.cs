using PrefeituraConecta.API.Dados;
using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Negocio
{
    public class FiltroSimplesNacional_BS
    {
        FiltroSimplesNacional_DB db = new FiltroSimplesNacional_DB();

        public bool Inserir(FiltroSimplesNacional filtroSimplesNacional)
        {
            try
            {
                return db.InserirFiltroSimplesNacional(filtroSimplesNacional);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FiltroSimplesNacional ObterFiltroSimplesNacional()
        {
            try
            {
                return db.ObterFiltroSimplesNacional();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
