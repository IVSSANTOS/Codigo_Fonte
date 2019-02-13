using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PrefeituraConecta.API.Utils.Serializacao
{
    public static class Serializacao_XML
    {
        public static string Serializar<T>(T obj)
        {

            XmlWriterSettings _xmlWriterSettings = new XmlWriterSettings();
            XmlSerializerNamespaces _xmlSerializerNamespaces = new XmlSerializerNamespaces();

            _xmlWriterSettings.NewLineChars = "";
            _xmlWriterSettings.NewLineHandling = NewLineHandling.None;
            _xmlWriterSettings.NewLineOnAttributes = false;
            _xmlWriterSettings.OmitXmlDeclaration = true;
            _xmlWriterSettings.Encoding = Encoding.UTF8;
            _xmlWriterSettings.Indent = false;


            _xmlSerializerNamespaces.Add("", "");

            StringWriter writer = new StringWriter();
            XmlWriter xmlWriter = XmlWriter.Create(writer, _xmlWriterSettings);

            XmlSerializer xs = new XmlSerializer(typeof(T));

            xs.Serialize(xmlWriter, obj, _xmlSerializerNamespaces);

            return writer.ToString();


        }

        public static T Deserializar<T>(string xml)
        {
            StringReader reader = new StringReader(xml);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            return (T)xmlSerializer.Deserialize(reader);
        }
    }
}
