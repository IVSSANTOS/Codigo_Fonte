using AutoMapper;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Models.Declaracoes;
using PrefeituraConecta.MVC.UI.Models.Graficos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            Configuration();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void Configuration()
        {
            this.CreateMap<PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ISSQN_ICMS,DECLARACOES_INCIDENCIA_ISSQN_ICMS_MODEL > ();
            this.CreateMap<PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ICMS,DECLARACOES_INCIDENCIA_ICMS_MODEL>();
            this.CreateMap<PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ISSQN,DECLARACOES_INCIDENCIA_ISSQN_MODEL>();


            CreateMap<PrefeituraConecta.API.Entidades.Usuario, Usuario>();
            CreateMap<PrefeituraConecta.API.Entidades.Graficos.OptanteSimplesNacional_e_MEI, OptanteSimplesNacional_e_MEI_Model>();
            CreateMap<PrefeituraConecta.API.Entidades.FiltroSimplesNacional, FiltroSimplesNacionalModel>();
            CreateMap<PrefeituraConecta.API.Entidades.FiltroNFS, FiltroNFSModel>();
            CreateMap<PrefeituraConecta.API.Entidades.SimuladorSimples, SimuladorSimplesModel>();
            CreateMap<PrefeituraConecta.API.Entidades.SimuladorCompleto, SimuladorCompletoModel>();
            CreateMap<PrefeituraConecta.API.Entidades.Declaracoes, DeclaracoesModel>();
        }
    }
}