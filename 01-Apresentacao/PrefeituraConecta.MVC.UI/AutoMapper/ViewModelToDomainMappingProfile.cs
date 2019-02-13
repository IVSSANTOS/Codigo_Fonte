using AutoMapper;
using PrefeituraConecta.MVC.UI.Models;
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
            CreateMap<PrefeituraConecta.API.Entidades.Usuario, Usuario>();
            CreateMap<PrefeituraConecta.API.Entidades.Graficos.OptanteSimplesNacional_e_MEI, OptanteSimplesNacional_e_MEI_Model>();
        }
    }
}