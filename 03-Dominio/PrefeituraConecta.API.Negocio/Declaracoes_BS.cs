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
                obj.RECEITAS_DECLARADAS_ISSQN = db.ObterContadorReceitasDeclaradasIssqn();
                obj.RECEITAS_DECLARADAS_ICMS = db.ObterContadorReceitasDeclaradasIcms();
                obj.SERVICOS_SEM_RETENCAO = db.ObterContadorServicosSemRetencao();
                obj.SERVICOS_COM_RETENCAO = db.ObterContadorServicosComRetencao();
                obj.SERVICOS_OUTROS_MUNICIPIOS = db.ObterContadorServicosOutrosMunicipios();
                obj.SERVICOS_LOCACAO = db.ObterContadorServicosLocacao();
                obj.SERVICOS_CONTABILIDADE = db.ObterContadorServicosContabilidade();
                obj.SERVICOS_EXTERIOR = db.ObterContadorServicosExterior();
                obj.COMERCIO_MERCADO_INTERNO = db.ObterContadorComercioMercadoInterno();
                obj.COMERCIO_EXTERIOR = db.ObterContadorComercioExterior();

                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
