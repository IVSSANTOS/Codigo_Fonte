using PrefeituraConecta.API.Dados;
using PrefeituraConecta.API.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefeituraConecta.API.Negocio
{
    public class Declaracoes_BS
    {
        Declaracoes_DB db = new Declaracoes_DB();
        Declaracoes obj = new Declaracoes();

        public Declaracoes ObterContadores()
        {
            try
            {
                obj.EMPRESAS = db.ObterContadorEmpresas();
                obj.TRANSMITIDAS = db.ObterContadorTransmitidas();

                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
