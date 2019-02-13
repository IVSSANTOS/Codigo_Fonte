using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace PrefeituraConecta.API.Dados
{
    public class DBConfiguration
    {
        private string _DBConfigurationSQL = string.Empty;



        public string GetconfigurationStringSQL()
        {

#if DEBUG
            _DBConfigurationSQL = @ConfigurationManager.ConnectionStrings["localConnectionString"].ToString(); ;
#else
            _DBConfigurationSQL =  @ConfigurationManager.ConnectionStrings["azureConnectionString"].ToString();
#endif
            return _DBConfigurationSQL;

        }
    }


}
