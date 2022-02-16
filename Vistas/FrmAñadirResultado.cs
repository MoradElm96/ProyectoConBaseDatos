using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FrmAñadirResultado : Form
    {
        public List<Atleta> listaAtletas;
        public List<Resultados> listaResultados;


        public FrmAñadirResultado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1Resultado_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombreCompletoPeleador = comboBoxNombreCompletoPeleador.Text;
            string nombreCompletoContrincante = comboBoxPeleadorRival.Text;
            string categoria = comboBoxCategoria.Text;
            string resultado = comboBoxResultado.Text;
            int ronda = (int)numericRonda.Value;
            string metodo = comboBoxMetodo.Text;
            if (validarCampos() == false)
            {
                if (Controladores.ControladorResultados.addResultado(nombreCompletoPeleador, nombreCompletoContrincante, categoria, resultado, ronda, metodo))

                {
                    MessageBox.Show("El resultado se ha guardado");


                }
                else
                {
                    MessageBox.Show("El resultado no se puede determinar, ponga bien los datos");
                }
            }
            else
            {
                MessageBox.Show(" Tiene que elegir una opcion en todos los campos." +
                    "Comprueba que has rellenado todos los campos." +
                    " Gracias");
            }
        }


        private bool validarCampos()
        {
            //para que no te deje añadir sin rellenar todos los campos
            //poner if comprobar con -1
            //este metodo valida que se hayan selecionado todos los combobox
            bool respuesta = false;
            if (
            comboBoxNombreCompletoPeleador.SelectedIndex.Equals(-1) ||
            comboBoxPeleadorRival.SelectedIndex.Equals(-1) ||
            comboBoxCategoria.SelectedIndex.Equals(-1) ||
            comboBoxResultado.SelectedIndex.Equals(-1) ||

            comboBoxMetodo.SelectedIndex.Equals(-1))
            {
                respuesta = true;
                //MessageBox.Show("Rellene todos los campos antes de añadir resultado");
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }



        private void FrmAñadirResultado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {

            /*
            listaAtletas = Controladores.ControladorAtleta.recuperarAtletas();
            listaResultados = Controladores.ControladorResultados.recuperarResultados();

            comboBoxNombreCompletoPeleador.DataSource = Controladores.ControladorAtleta.recuperarAtletas();

            comboBoxNombreCompletoPeleador.DisplayMember = "NombreCompleto";

            comboBoxPeleadorRival.DataSource = Controladores.ControladorAtleta.recuperarAtletas();
            comboBoxPeleadorRival.DisplayMember = "NombreCompleto";*/

        }

        private void comboBoxPeleadorRival_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
