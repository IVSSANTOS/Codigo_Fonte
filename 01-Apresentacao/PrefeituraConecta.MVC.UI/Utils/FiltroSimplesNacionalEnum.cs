using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Utils
{
    public sealed class Consulta
    {

        public static readonly Consulta PADRAO = new Consulta("Incidência de ISSQN e ICMS");
        public static readonly Consulta ISSQN = new Consulta("Incidência de ISSQN");
        public static readonly Consulta ICMS = new Consulta("Incidência de ICMS");

        private Consulta(string _value)
        {
            Value = _value;
        }

        public Consulta()
        {
                
        }

        public string Value { get; private set; }


        public List<Consulta> FiltroSimplesNacionalEnumTipoConsulta()
        {
            List<Consulta> lista = new List<Consulta>();
            lista.Add(PADRAO);
            lista.Add(ISSQN);
            lista.Add(ICMS);
            
            return lista;
        }
    }

    public sealed class ConsolidadoPor
    {

        public static readonly ConsolidadoPor matriz = new ConsolidadoPor("Matriz");
        public static readonly ConsolidadoPor cnpj = new ConsolidadoPor("CNPJ");
        public static readonly ConsolidadoPor declaracao = new ConsolidadoPor("Declaração");

        private ConsolidadoPor(string _value)
        {
            Value = _value;
        }

        public ConsolidadoPor()
        {

        }

        public string Value { get; private set; }


        public List<ConsolidadoPor> FiltroSimplesNacionalEnumConsolidadoPor()
        {
            List<ConsolidadoPor> lista = new List<ConsolidadoPor>();
            lista.Add(matriz);
            lista.Add(cnpj);
            lista.Add(declaracao);

            return lista;
        }
    }

    public sealed class TipoEmpresa
    {

        public static readonly TipoEmpresa Todas = new TipoEmpresa("--Todas--");
        public static readonly TipoEmpresa estabelecida = new TipoEmpresa("Estabelecidas");
        public static readonly TipoEmpresa nao_estabelecida = new TipoEmpresa("Não Estabelecidas");

        private TipoEmpresa(string _value)
        {
            Value = _value;
        }

        public TipoEmpresa()
        {

        }

        public string Value { get; private set; }


        public List<TipoEmpresa> FiltroSimplesNacionalEnumTipoEmpresa()
        {
            List<TipoEmpresa> lista = new List<TipoEmpresa>();
            lista.Add(Todas);
            lista.Add(estabelecida);
            lista.Add(nao_estabelecida);

            return lista;
        }
    }

    public sealed class TipoDeclaracao
    {

        public static readonly TipoDeclaracao Todas = new TipoDeclaracao("--Todas--");
        public static readonly TipoDeclaracao ultima = new TipoDeclaracao("Última (Apuração/Retificação)");
        public static readonly TipoDeclaracao primeira = new TipoDeclaracao("Primeira (Apuração/Original)");

        private TipoDeclaracao(string _value)
        {
            Value = _value;
        }

        public TipoDeclaracao()
        {

        }

        public string Value { get; private set; }


        public List<TipoDeclaracao> FiltroSimplesNacionalEnumTipoDeclaracao()
        {
            List<TipoDeclaracao> lista = new List<TipoDeclaracao>();
            lista.Add(Todas);
            lista.Add(ultima);
            lista.Add(primeira);

            return lista;
        }
    }

    public sealed class Regime
    {

        public static readonly Regime Todas = new Regime("--Todas--");
        public static readonly Regime Competencia = new Regime("Competência");
        public static readonly Regime Caixa = new Regime("Caixa");

        private Regime(string _value)
        {
            Value = _value;
        }

        public Regime()
        {

        }

        public string Value { get; private set; }


        public List<Regime> FiltroSimplesNacionalEnumRegime()
        {
            List<Regime> lista = new List<Regime>();
            lista.Add(Todas);
            lista.Add(Competencia);
            lista.Add(Caixa);

            return lista;
        }
    }


}