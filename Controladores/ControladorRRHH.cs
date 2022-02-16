using Newtonsoft.Json;
using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controladores
{
    public class ControladorRRHH
    {
        private List<ResponsableRRHH> listaDepartamentoRRHH= new List<ResponsableRRHH>();
        private void cargarDepartamentoRRHH()
        {/*
            listaDepartamentoRRHH.Add(new ResponsableRRHH("Root", "1234"));
            listaDepartamentoRRHH.Add(new ResponsableRRHH("Dana", "1234"));
            */
            listaDepartamentoRRHH = Controladores.ControladorRRHH.recuperarResponsables();

        }
        public bool validarLogin(string Responsable, string clave)
        {
            cargarDepartamentoRRHH();
            string usuarioEnMinuscula = Responsable.Trim().ToLower();
            int posicion = listaDepartamentoRRHH.FindIndex((x) => x.NombreResponsable.ToLower() == usuarioEnMinuscula);
            if (posicion != -1)
            {
                if (compararClaveSHA1(listaDepartamentoRRHH[posicion].Clave, generarClaveSHA1(clave))) //Clave == clave)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;

        }
         


        public static List<ResponsableRRHH> recuperarResponsables()
        {
            List<ResponsableRRHH> listaDepartamentoRRHH = new List<ResponsableRRHH>();


            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroUsuariosRRHH")/*ruta*/);
                listaDepartamentoRRHH = JsonConvert.DeserializeObject<List<ResponsableRRHH>>(archivoJson);
            }
            catch (Exception) { }

            return listaDepartamentoRRHH;
        }


        public static bool guardarResponsable(List<ResponsableRRHH> lista)
        {
            try
            {
                string archivoJson = System.Text.Json.JsonSerializer.Serialize(lista);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroUsuariosRRHH"), archivoJson);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool addResponsable(string nombreResponsable, string clave, string claveRepetida )
        {
            List<ResponsableRRHH> lista = recuperarResponsables();
            string idResponsable = "0";
            if (lista.Count > 0)
            {
                lista.Sort((a, b) =>
                {
                    return Convert.ToInt32(b.IdResponsable) - Convert.ToInt32(a.IdResponsable);
                });
                idResponsable = "" + (Convert.ToInt32(lista.First().IdResponsable) + 1);
            }
            ResponsableRRHH responsableRRHH = new ResponsableRRHH(idResponsable, nombreResponsable, clave,claveRepetida);
            lista.Add(responsableRRHH);
            return guardarResponsable(lista);
        }

        public static bool comprobarNombreUsuario(string nombreResponsable)
        {
            List<ResponsableRRHH> listaDepartamentoRRHH = recuperarResponsables();
            if (listaDepartamentoRRHH.FindIndex(x => x.NombreResponsable == nombreResponsable) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        /*
        public static bool comprobarClave(string clave)
        {
            List<ResponsableRRHH> listaDepartamentoRRHH = recuperarResponsables();
            if (listaDepartamentoRRHH.FindIndex(x => x.Clave == clave) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/


        public byte[] generarClaveSHA1(string cadena)
        {
            byte[] claveHash;
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] messageBytes = ue.GetBytes(cadena);
            SHA256 shHash = SHA256.Create();
            claveHash = shHash.ComputeHash(messageBytes);
            return claveHash;
        }
        private bool compararClaveSHA1(byte[] cadena1, byte[] cadena2)
        {
            bool sonIguales = true;


            //Compare the values of the two byte arrays.
            for (int x = 0; x < cadena1.Length; x++)
            {
                if (cadena1[x] != cadena2[x])
                {
                    sonIguales = false;
                }
            }
            return sonIguales;
        }




    }
}
