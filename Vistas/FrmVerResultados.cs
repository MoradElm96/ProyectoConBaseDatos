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
    public partial class FrmVerResultados : Form
    {
        List<Resultados> listaResultados = new List<Resultados>();
        public FrmVerResultados()
        {
            InitializeComponent();
        }

        private void FrmVerResultados_Load(object sender, EventArgs e)
        {
            cargarDatosEnListbox();
        }

        private void cargarDatosEnListbox()
        {
            lstBoxNombreCompleto.DataSource = Controladores.ControladorResultados.recuperarResultados();
            //  lstBoxNombreCompleto.DisplayMember = "NombreCompletoPrimerPeleador";
            lstBoxNombreCompleto.ValueMember = "NombreCompletoPeleador";

            lstCategoria.DataSource = Controladores.ControladorResultados.recuperarResultados();

            lstCategoria.ValueMember = "Categoria";

            lstResultado.DataSource = Controladores.ControladorResultados.recuperarResultados();
            lstResultado.ValueMember = "Resultado";
            listMetodo.DataSource = Controladores.ControladorResultados.recuperarResultados();
            listMetodo.ValueMember = "Metodo";
            listRonda.DataSource = Controladores.ControladorResultados.recuperarResultados();
            listRonda.ValueMember = "Ronda";
            listBox1Contrincante.DataSource = Controladores.ControladorResultados.recuperarResultados();
            listBox1Contrincante.ValueMember = "NombreCompletoContrincante";


        }


        private void lstBoxNombreCompleto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
