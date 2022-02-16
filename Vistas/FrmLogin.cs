using Proyecto.Clases;
using Proyecto.Controladores;
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
    public partial class FrmLogin : Form
    {
        private List<ResponsableRRHH> listaDepartamentoRRHH = new List<ResponsableRRHH>();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        private void cmdAceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (new ControladorRRHH().validarLogin(this.txtNombreRRHH.Text, this.txtClave.Text))
            {
                this.Close();

                FrmGestionDeAtletas frmGestionDeAtletas = new FrmGestionDeAtletas();
                frmGestionDeAtletas.ShowDialog();

            }
            else
            {
                txtNombreRRHH.Clear();
                txtClave.Clear();
                this.lblError.Visible = true;

            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Has pulsado Cancelar");
            this.Close();
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            FrmRegistroResponsable frmRegistroUsuario = new FrmRegistroResponsable();
            frmRegistroUsuario.ShowDialog();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                    this.Close();

                    FrmGestionDeAtletas frmGestionDeAtletas = new FrmGestionDeAtletas();
                    frmGestionDeAtletas.ShowDialog();

                    txtNombreRRHH.Clear();
                    txtClave.Clear();
                    this.lblError.Visible = true;

                
            }
        }

        private void txtNombreRRHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }

}
