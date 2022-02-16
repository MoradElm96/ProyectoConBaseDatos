using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto.Clases
{

 
    public class Atleta
    {
        //atributos
        public int IdAtleta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Peso { get; set; }
        public string Edad { get; set; }
        public string Salario { get; set; }
        public string  Categoria { get; set; }

        public string Cif { get; set; }

        public string Telefono { get; set; }
      

        public string Correo { get; set; }
        public string NombreCompleto { get { return Nombre +"_" + Apellido; } }// campo compelto de nombre mas apellidos

        public Atleta()
        {

        }

        public Atleta(int idAtleta)
        {
            this.IdAtleta = idAtleta;
        }

        //coonstructor vacio


        //constructor general de peleador
        
        public Atleta(int idAtleta,string nombre, string apellido, string nacionalidad, string sexo, string edad, string peso, string salario, string categoria, string cif, string telefono, string correo)
        {
            this.IdAtleta = idAtleta;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Edad = edad;
            this.Salario = salario;
            this.Categoria = categoria;
            this.Cif = cif;
            this.Telefono = telefono;
            this.Correo = correo;

        }

      
       
       

       



    }
}


    
  
