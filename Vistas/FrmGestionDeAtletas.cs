using MySql.Data.MySqlClient;
using Proyecto.Clases;
using Proyecto.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Proyecto.Vistas
{
    /// <summary>
    /// esta clase es donde se hacen todas las gestiones crud de los atletas.
    /// </summary>

    public partial class FrmGestionDeAtletas : Form
    {
        /// <summary>
        /// dataset en el que estan los datos en memoria.
        /// </summary>
        public DataSet dataSet = ControladorAtleta.recuperarAtletasDataSet();
        public DataSet dsTabla;




        public FrmGestionDeAtletas()
        {
            InitializeComponent();


        }


        private void FrmGestionDeAtletas_Load(object sender, EventArgs e)
        {
            cargarDatos();


        }



        private void button1_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// funcion que hace que una vez el usuario introduzca los datos en los textbox y estos se validen, estos se graben en  la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContratar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nacionalidad = txtNacionalidad.Text;
            string sexo = SelecionaSexo();
            string edad = txtEdad.Text;
            string peso = txtPeso.Text;
            string salario = txtSalario.Text;
            string categoria = comboBoxCategoria.Text;
            string cif = mtxCIF.Text;
            string telefono = mtxTelefono.Text;
            string correo = txtCorreo.Text;



            if (validarCampos())
            {
                if (ControladorAtleta.addAtleta(nombre, apellido, nacionalidad, sexo, edad, peso, salario, categoria, cif, telefono, correo))
                {
                    MessageBox.Show("El atleta se ha contratado");
                    cargarDatos();

                }
                else
                {
                    MessageBox.Show("El atleta no cumple los requisitos para su contratacion");
                }
            }
            else
            {
                MessageBox.Show("Corrija los campos erroneos");
            }
        }





        /// <summary>
        /// funcion para validar cammpos, en este caso solo tiene en cuenta que el nombre no este vacio y el correo tenga el formato correcto.
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {

            string nombre = txtNombre.Text.Trim();

            string correo = txtCorreo.Text.Trim();


            bool respuesta = true;
            string listadoErrores = "";
            Regex rxCorreo = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            // validar que el  nombre de cliente no es vacío
            // validar que el nombre no está repetido
            if (!nombre.Equals(""))
            {
                if (!rxCorreo.IsMatch(correo))
                {
                    lblErrorCorreo.Visible = true;

                    listadoErrores += " Error en el correo o Correo repetido";
                    respuesta = false;
                }
                else
                {
                    respuesta = true;
                }
            }
            else
            {
                lblErrorNombre.Visible = true;
                listadoErrores += " Error en el nombre";
                respuesta = false;
            }
            return respuesta;



        }



        /// <summary>
        ///  funcion del radio button seleccionado escribe un valor u otro.
        /// </summary>
        /// <returns></returns>
        private string SelecionaSexo()
        {
            string seleccionGenero = " ";

            if (radioBMasculino.Checked == true)
            {
                seleccionGenero = radioBMasculino.Text;
            }

            if (radioBFemenino.Checked == true)
            {
                seleccionGenero = radioBFemenino.Text;
            }
            return seleccionGenero;

        }



        /// <summary>
        /// metodo para eliminar desde el datagrid, si se selecciona algun registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDespedir_Click(object sender, EventArgs e)



        {
            int contadorBorrados = 0;
            foreach (DataGridViewRow fila in dgvGestionAtletas.SelectedRows)

            {
                if (dgvGestionAtletas.SelectedRows.Count > 0)
                {
                    //preguntar como borrar varios
                    ControladorAtleta.eliminarAtletas(Convert.ToInt32(dgvGestionAtletas.CurrentRow.Cells[0].Value.ToString()));
                    contadorBorrados++;

                }
            }
            MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " atletas");
            cargarDatos();




        }

        /// <summary>
        /// para cargar los datos del dataset.
        /// </summary>
        private void cargarDatos()
        {


            dgvGestionAtletas.DataSource = dataSet.Tables[0];






        }
        /// <summary>
        /// metodo para que cuandio se pulse en boton Refrescar, actualize los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            cargarDatos();


        }









        /// <summary>
        /// metodo para ordenar, pero no lo uso. porque el id ya es autoincrementado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {


            //  listaAtletas.Order(listaAtletas => listaAtletas.IdAtleta);


            // listaAtletas.Sort((a, b) => (Convert.ToInt32(a.IdAtleta) - Convert.ToInt32(b.IdAtleta))/*a.Nombre).CompareTo(b.Nombre)*/);
            // dgvGestionAtletas.Refresh();

            //  dgvGestionAtletas.DataSource = listaAtletas;





        }

        /// <summary>
        /// para que solo se puedan introducir numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// funcion para que solo se puedan escribir letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// funcion para que solo se puedan escribir letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// funcion para que solo se puedan escribir letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        /// <summary>
        /// para que solo se puedan introducir numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// para que solo se puedan introducir numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {

                e.Handled = true;
            }
        }

        /// <summary>
        /// para que solo se puedan introducir numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void mtxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// este boton actuliza y graba los cambios realizados en el datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click_2(object sender, EventArgs e)
        {



            if (ControladorAtleta.guardarCambiosDataSet(this.dataSet))
            {
                MessageBox.Show("Datos guardados");
                cargarDatos();
            }
            else
            {
                MessageBox.Show("No se han podido guardar los cambios");
            }


        }
        /// <summary>
        /// metodo que valida los campos a modificar dentro de un dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validarCeldas(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // e es un objeto que contiene las características del evento que se ha producido
            // vamos a validar la columna 2 que es el CIF de la empresa
            if (e.ColumnIndex == 11)//columna del email
            {
                if (!Regex.IsMatch(e.FormattedValue.ToString(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("El dato introducido no es de tipo mail", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvGestionAtletas.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo mail";
                    e.Cancel = true;
                }

            }
            else if (e.ColumnIndex == 9)// columna del nif
            {
                if (!Regex.IsMatch(e.FormattedValue.ToString(), @"^[0-9]{8}[A-Z]$", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("El dato introducido no es de tipo CIF", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvGestionAtletas.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo CIF";
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {// columna del nombre, para que no este vacia

                if (e.FormattedValue.ToString().Equals(""))
                {
                    MessageBox.Show("El campo nombre no puede estar vacio", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvGestionAtletas.Rows[e.RowIndex].ErrorText = "el nombre no puede estar vacio";
                    e.Cancel = true;

                }
            }
        }


        private void button1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}




