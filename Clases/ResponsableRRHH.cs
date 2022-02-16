using Proyecto.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    [Serializable]
    public class ResponsableRRHH
    {

        public string IdResponsable { get; set; }
        public string NombreResponsable { get; set; }
        //public string Clave { get; set; }
        public byte[] Clave { get; set; }
        public byte[] ClaveRepetida { get; set; }
        public string ClaveCifrada { get { return System.Text.Encoding.UTF8.GetString(Clave); } }
        public string ClaveCifradaRepetida { get { return System.Text.Encoding.UTF8.GetString(ClaveRepetida); } }


        public ResponsableRRHH()
        {
            
        }
        public ResponsableRRHH(string nombreResponsable, string clave, string claveRepetida)
        {
            this.NombreResponsable = nombreResponsable;
            this.Clave = new ControladorRRHH().generarClaveSHA1(clave);
            this.ClaveRepetida = new ControladorRRHH().generarClaveSHA1(claveRepetida); 
        }


        public ResponsableRRHH(string idResponsable, string nombreResponsable, string clave, string claveRepetida) 
{
            this.IdResponsable = idResponsable;
            this.NombreResponsable = nombreResponsable;
            this.Clave = new ControladorRRHH().generarClaveSHA1(clave);
            this.ClaveRepetida = new ControladorRRHH().generarClaveSHA1(claveRepetida);

        }

        

    }

      

    }

