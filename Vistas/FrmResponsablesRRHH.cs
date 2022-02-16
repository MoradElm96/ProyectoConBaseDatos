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
    public partial class FrmResponsablesRRHH : Form
    {
        List<ResponsableRRHH> listaDepartamentoRRHH = new List<ResponsableRRHH>();

        public FrmResponsablesRRHH()
        {

            InitializeComponent();

        }

        private void FrmResponsablesRRHH_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            listaDepartamentoRRHH = Controladores.ControladorRRHH.recuperarResponsables();

            listaDepartamentoRRHH.Sort((a, b) => (Convert.ToInt32(a.IdResponsable) - Convert.ToInt32(b.IdResponsable)));

            dgvResponsables.Refresh();
            dgvResponsables.DataSource = listaDepartamentoRRHH;



            dgvResponsables.Columns[2].Visible = false;
            dgvResponsables.Columns[3].Visible = false;




        }


        private void dgvResponsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
