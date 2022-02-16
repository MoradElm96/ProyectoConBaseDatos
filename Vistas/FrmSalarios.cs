using Proyecto.Clases;
using Proyecto.Controladores;
using System;
using System.Collections;
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
    public partial class FrmSalarios : Form
    {
        List<Atleta> listaAtletas;
        DataSet DataSet = ControladorAtleta.recuperarAtletasDataSet();

        public FrmSalarios()
        {
            InitializeComponent();
        }
        //cargo la lsita en el data grid
        private void FrmSalarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.atletas' Puede moverla o quitarla según sea necesario.
            this.atletasTableAdapter.Fill(this.proyectoDataSet.atletas);
            //listaAtletas = Controladores.ControladorAtleta.recuperarAtletas();
            dgvSalarios.Refresh();
            dgvSalarios.DataSource = DataSet.Tables[0].DefaultView;

            
            



        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {


          //  listaAtletas.Sort((a, b) => (Convert.ToInt32(b.Salario) - Convert.ToInt32(a.Salario)));
            //dgvSalarios.Refresh();
            //dgvSalarios.DataSource = listaAtletas;


        }

        //este boton muestra los salarios mas altos

        private void button1_Click(object sender, EventArgs e)
        {
            
            //string text = string.Empty;

            //listaAtletas.Sort((a, b) => (Convert.ToInt32(b.Salario) - Convert.ToInt32(a.Salario))/*a.Nombre).CompareTo(b.Nombre)*/);

            //salario mas alto




            //int maximo = listaAtletas.Max(x => Convert.ToInt32(x.Salario));


            //  string nombreAtletaConMasSueldo = listaAtletas 





          //  MessageBox.Show("La bolsa mas alta fue de  " + maximo + "$");

        }


        //este otro boton muestra el salario mas bajo
        private void button2_Click(object sender, EventArgs e)
        {

         //   int minimo = listaAtletas.Min(x => Convert.ToInt32(x.Salario));

            //MessageBox.Show("La bolsa mas baja fue de  " + minimo + "$");

        }
    }
}
