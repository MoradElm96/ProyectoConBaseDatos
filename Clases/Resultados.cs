using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class Resultados
    {
      //  public string IdResultado { get; set; }
        public string NombreCompletoPeleador { get; set; }
        public string NombreCompletoContrincante { get; set; }
        public string Categoria { get; set; }
        public string Resultado { get; set; }
        public int Ronda { get; set; }
        public string Metodo { get; set; }

        public Resultados()
        {

        }

        public Resultados(string nombreCompletoPeleador, string nombreCompletoContrincante, string categoria, string resultado, int ronda, string metodo)
        {
            this.NombreCompletoPeleador = nombreCompletoPeleador;
            this.NombreCompletoContrincante = nombreCompletoContrincante;
            this.Categoria = categoria;
            this.Resultado = resultado;
            this.Ronda = ronda;
            this.Metodo = metodo;
        }
        
    }
}
