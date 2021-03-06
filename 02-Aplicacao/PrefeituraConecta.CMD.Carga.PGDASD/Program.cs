﻿using PrefeituraConecta.API.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PrefeituraConecta.CMD.Carga.PGDASD
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivos = Directory.GetFiles(ConfigurationManager.AppSettings["DiretorioArquivos"].ToString());
            var ArquivosParaCarregar = ConfigurationManager.AppSettings["ArquivosParaCarregar"].ToString();
            var ArquivosCarregados = ConfigurationManager.AppSettings["ArquivosCarregados"].ToString();

            SimplesNacionalBS simplesNacionalBS = new SimplesNacionalBS();

            Console.WriteLine(" ----- INICIO DO PROCESSAMENTO ----- {0},", DateTime.Now);

            foreach (var arquivo in arquivos)
            {


                Console.WriteLine("Inicio da carga do arquivo: {0}", Path.GetFileName(arquivo).ToString());

                simplesNacionalBS.ImportarArquivo_PGDASD(arquivo);

                Console.WriteLine("Fim da carga do arquivo: {0}", Path.GetFileName(arquivo).ToString());

                if (!File.Exists(ArquivosCarregados + "\\" + Path.GetFileName(arquivo).ToString()))
                {
                    File.Move(ArquivosParaCarregar + "\\" + Path.GetFileName(arquivo).ToString(), ArquivosCarregados + "\\" + Path.GetFileName(arquivo).ToString());

                }
                else
                {
                    File.Delete(ArquivosParaCarregar + "\\" + Path.GetFileName(arquivo).ToString());

                }

            }

            Console.WriteLine(" ----- FINAL DO PROCESSAMENTO ----- {0},", DateTime.Now);
            Console.ReadLine();
        }
    }
}

