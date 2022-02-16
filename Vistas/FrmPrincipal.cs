using Proyecto.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;


namespace Proyecto
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {

            InitializeComponent();


        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {




        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Application.Exit();





        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

            //para enlazar a ventana

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FrmAtletas frmAtletas = new FrmAtletas();
            frmAtletas.ShowDialog();

        }



        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FrmSalarios frmSalarios = new FrmSalarios();
            frmSalarios.ShowDialog();

        }

        private void toolStripLabelGestionAtletas_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();



        }



        private void añadirResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAñadirResultado frmAñadirResultado = new FrmAñadirResultado();
            frmAñadirResultado.ShowDialog();
        }

        private void toolStripWebPage_Click(object sender, EventArgs e)
        {
            FrmWebPage frmWebPage = new FrmWebPage();
            frmWebPage.ShowDialog();
        }

        private void toolstripMapa_Click(object sender, EventArgs e)
        {
            FrmLocalizacion frmLocalizacion = new FrmLocalizacion();
            frmLocalizacion.ShowDialog();
        }

        private void toolStripLabelArchivo_Click(object sender, EventArgs e)
        {

        }

        private void verResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerResultados frmVerResultados = new FrmVerResultados();
            frmVerResultados.ShowDialog();
        }

        private void toolStripLabelCartelera_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripLabelCartelera_Click(object sender, EventArgs e)
        {
        }

        private void toolStripAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            frmAyuda.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmRegistroResponsable frmRegistroUsuario = new FrmRegistroResponsable();
            frmRegistroUsuario.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FrmResponsablesRRHH frmResponsablesRRHH = new FrmResponsablesRRHH();
            frmResponsablesRRHH.ShowDialog();

        }

        private void FrmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
