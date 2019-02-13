using System;
using System.Collections.Generic;
using System.Text;

namespace PrefeituraConecta.API.Entidades.Arquivos
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CampoArquivoPGDASD : Attribute
    {
        public CampoArquivoPGDASD(int _ordem) : base()
        {
            this.Ordem = _ordem;
        }

        public int Ordem { get; set; }
    }
}
