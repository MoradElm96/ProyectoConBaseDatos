using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Configuration;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto.Controladores
{
   public  class ControladorResultados
    {

        public static List<Resultados> recuperarResultados()
        { 
            
            List<Resultados> listaResultados = new List<Resultados>();
          

            try
            {
                string archivoJsonn = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroResultados"));
                listaResultados = JsonConvert.DeserializeObject<List<Resultados>>(archivoJsonn);
            }
            catch (Exception) { }

            return listaResultados;
            



        }

     
        public static bool guardarResultados(List<Resultados> lista)
        {
            try
            {
                string archivoJsonn = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroResultados"), archivoJsonn);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public static bool addResultado(string nombreCompletoPeleador,string nombreCompletoContrincante, string categoria, string resultado, int ronda, string metodo)
        {
            List<Resultados> lista = recuperarResultados();

         
            Resultados resultadoss = new Resultados(nombreCompletoPeleador,nombreCompletoContrincante, categoria, resultado, ronda, metodo);
            lista.Add(resultadoss);
            return guardarResultados(lista);
        }


    }
}
