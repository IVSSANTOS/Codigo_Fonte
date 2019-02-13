using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using System.Web.Helpers;
using AutoMapper;
using PrefeituraConecta.MVC.UI.Models;

[assembly: OwinStartup(typeof(PrefeituraConecta.MVC.UI.Startup))]

namespace PrefeituraConecta.MVC.UI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Autenticacao/Login")
            });

            AntiForgeryConfig.UniqueClaimTypeIdentifier = "Login";

        }
    }
}
