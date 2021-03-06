﻿using AutoMapper;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Models.Declaracoes;
using PrefeituraConecta.MVC.UI.Models.Graficos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            Configuration();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configuration()
        {
            this.CreateMap<DECLARACOES_INCIDENCIA_ISSQN_ICMS_MODEL, PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ISSQN_ICMS>();
            this.CreateMap<DECLARACOES_INCIDENCIA_ICMS_MODEL, PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ICMS>();
            this.CreateMap<DECLARACOES_INCIDENCIA_ISSQN_MODEL, PrefeituraConecta.API.Entidades.DECLARACOES_TRANSM_INCIDENCIA_ISSQN>();
            this.CreateMap<Usuario, PrefeituraConecta.API.Entidades.Usuario>();
            this.CreateMap<OptanteSimplesNacional_e_MEI_Model, PrefeituraConecta.API.Entidades.Graficos.OptanteSimplesNacional_e_MEI>();
            this.CreateMap<FiltroSimplesNacionalModel, PrefeituraConecta.API.Entidades.FiltroSimplesNacional>();
            this.CreateMap<FiltroNFSModel, PrefeituraConecta.API.Entidades.FiltroNFS>();
            this.CreateMap<SimuladorSimplesModel, PrefeituraConecta.API.Entidades.SimuladorSimples>();
            this.CreateMap<SimuladorCompletoModel, PrefeituraConecta.API.Entidades.SimuladorCompleto>();
            this.CreateMap<DeclaracoesModel, PrefeituraConecta.API.Entidades.Declaracoes>();
        }
    }
}