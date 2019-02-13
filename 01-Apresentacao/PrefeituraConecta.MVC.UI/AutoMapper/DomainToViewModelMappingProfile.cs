using AutoMapper;
using PrefeituraConecta.MVC.UI.Models;
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
            this.CreateMap<Usuario, PrefeituraConecta.API.Entidades.Usuario>();
            this.CreateMap<OptanteSimplesNacional_e_MEI_Model, PrefeituraConecta.API.Entidades.Graficos.OptanteSimplesNacional_e_MEI>();
        }
    }
}