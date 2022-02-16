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
    public partial class FrmRegistroResponsable : Form
    {
        public List<ResponsableRRHH> listaDepartamentoRRHH = new List<ResponsableRRHH>();

        public FrmRegistroResponsable()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombreResponsable = textBox1Nombre.Text;
            string Clave = textBoxClave.Text;
            string ClaveRepetida = textBoxClave2.Text;



            if (validarCampos())
            {
                if (Controladores.ControladorRRHH.addResponsable(nombreResponsable, Clave, ClaveRepetida))
                {
                    MessageBox.Show("El usuario se ha guardado");
                    cargarDatos();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("El usuario no se ha podido guardar");
                }
            }
            else
            {
                MessageBox.Show("Corrija los campos erroneos");
            }


        }

        private bool validarCampos()
        {

            string nombreResponsable = textBox1Nombre.Text.Trim();
            string clave = textBoxClave.Text.Trim();
            string claveRepetida = textBoxClave2.Text.Trim();

            bool respuesta = true;
            string listadoErrores = "";


            // validar que el  nombre de cliente no es vacío
            // validar que el nombre no está repetido
            if (nombreResponsable == "" || Controladores.ControladorRRHH.comprobarNombreUsuario(nombreResponsable))
            {
                label1UsuarioExiste.Visible = true;
                label1ErrorNommbre.Visible = true;
                listadoErrores += " Error en el nombre";
                textBox1Nombre.Clear();
                textBoxClave.Clear();
                textBoxClave2.Clear();
                respuesta = false;
            }
            //valida que la clave sea la misma
            /*
            if (clave != claveRepetida || Controladores.ControladorRRHH.comprobarClave(clave))
            {
                lblErrorClave.Visible = true;
                label1ClaveNocoincide.Visible = true;
                listadoErrores += "Error clave no coincide";
                textBox1Nombre.Clear();
                textBoxClave.Clear();
                textBoxClave2.Clear();
                respuesta = false;
            }*/

            return respuesta;

        }


        private void cargarDatos()
        {
            listaDepartamentoRRHH = Controladores.ControladorRRHH.recuperarResponsables();


        }




        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label3Clave2_Click(object sender, EventArgs e)
        {

        }

        private void label2Clave_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClave2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1Nombre.Clear();
            textBoxClave.Clear();
            textBoxClave2.Clear();
            this.Close();
        }

        private void textBox1Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClave2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nombreResponsable = textBox1Nombre.Text;
                string Clave = textBoxClave.Text;
                string ClaveRepetida = textBoxClave2.Text;



                if (validarCampos())
                {
                    if (Controladores.ControladorRRHH.addResponsable(nombreResponsable, Clave, ClaveRepetida))
                    {
                        MessageBox.Show("El usuario se ha guardado");
                        cargarDatos();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no se ha podido guardar");
                    }
                }
                else
                {
                    MessageBox.Show("Corrija los campos erroneos");
                }


            }
        }

        private void textBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
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
