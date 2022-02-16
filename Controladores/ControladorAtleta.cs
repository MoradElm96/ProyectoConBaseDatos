using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Configuration;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto.Controladores
{
    public static class ControladorAtleta
    {
        
        /// <summary>
        /// Este metodo se utiliza para la pruba unitaria 
        /// </summary>
        /// <returns></returns>

       
       
            public static bool ComprobarConexion()
            {
                try
                {

                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                cnn.Close();
                    
                return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Conexión NO realizada por " + e.Message);
                    return false;
                }
            }

        /// <summary>
        /// Este metodo recupera la informacion de la base de datos y la carga en un objeto de tipo dataset.
        /// </summary>
        /// <returns></returns>




        public static DataSet recuperarAtletasDataSet()
        {
            DataSet dataSet = new DataSet();
            ///se hace referencia al string donde tengo la conexion a la base de datos, guardado en appconfig.

            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM atletas", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo bbdd atletas " + e.Message);
            }
            return dataSet;
        }

        /// <summary>
        /// metodo para actualizar el dataset y en consecuencia la base de datos.
        /// cuando se mustra el data grid view y se escribe en algun campo y le damos al btn actualizar esto actuliza ese campo en concreto y lo graba en la base de datos.
        /// </summary>
        /// <param name="dataSet">Este es el objeto de tipo dataset que se recibe en el que el usuario hace los cambios.</param>
        /// <returns></returns>
        public static bool guardarCambiosDataSet(DataSet dataSet)
        {
            bool respuesta = true;
            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM atletas", cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);
                builder.GetUpdateCommand();  // genera todos los commandos de insert,delete…
                dataAdapter.Update(dataSet);
                dataAdapter.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error actualizando bbdd atletas " + e.Message);
                respuesta = false;
            }
            return respuesta;
        }


        public static DataTable recuperarAtletasDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM atletas", cnn);
                dataAdapter.Fill(dataTable);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo bbdd atletas " + e.Message);
            }
            return dataTable;
        }

        /// <summary>
        /// metodo para eliminar por registro por id, en el datagrid, y esto se refleja tambien en la base de datos, en resumen es un delete.
        /// 
        /// </summary>
        /// <param name="idAtleta"></param>
        /// <returns></returns>


        public static bool eliminarAtletas(int idAtleta)
        {
            bool respuesta = false;

            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "DELETE FROM ATLETAS WHERE IdAtleta=@IdAtleta";
                comando.Parameters.AddWithValue("@IdAtleta",idAtleta);
                comando.Prepare();


                

                if (comando.ExecuteNonQuery()==1) 
                { 
                    respuesta = true;
                }

               
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo bbdd usuarios " + e.Message);
            }

            return respuesta;
        }



        /// <summary>
        /// metodo para agregar nuevo registro a la base de datos, en este caso es un atlteta.
        /// </summary>
        /// <param name="nombre">Nombre del atleta.</param>
        /// <param name="apellido">Apellido del atleta.</param>
        /// <param name="nacionalidad">Nacionalidad del atleta.</param>
        /// <param name="sexo">Genero del atleta.</param>
        /// <param name="edad">Edad del atleta.</param>
        /// <param name="peso">Peso del atleta.</param>
        /// <param name="salario">Salario del atleta.</param>
        /// <param name="categoria">Categoria del atleta.</param>
        /// <param name="cif">Cif del atleta.</param>
        /// <param name="telefono">Telefono del atleta.</param>
        /// <param name="correo">Correo del atleta.</param>
        /// <returns></returns>

        public static bool addAtleta(string nombre, string apellido, string nacionalidad, string sexo, string edad, string peso, string salario, string categoria, string cif, string telefono, string correo)
        {
            bool respuesta = true;
            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "INSERT INTO `Atletas`(`Nombre`, `Apellido`, `Nacionalidad`,`Sexo`, `Peso`, `Edad`, `Salario`, `Categoria`, `Cif`, `Telefono`, `Correo`)VALUES " +
                    "(@Nombre,@Apellido,@Nacionalidad,@Sexo,@Peso,@Edad,@Salario,@Categoria,@Cif,@Telefono,@Correo)";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido",apellido);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@Sexo",sexo);
                comando.Parameters.AddWithValue("@Peso",peso);
                comando.Parameters.AddWithValue("@Edad",edad);
                comando.Parameters.AddWithValue("@Salario",salario);
                comando.Parameters.AddWithValue("@Categoria",categoria);
                comando.Parameters.AddWithValue("@Cif",cif);
                comando.Parameters.AddWithValue("@Telefono",telefono);
                comando.Parameters.AddWithValue("@Correo",correo);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.InsertCommand = comando;
                if (adapter.InsertCommand.ExecuteNonQuery() == 0)
                {
                    respuesta = false;
                    
                }
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Introduciendo datos en  bbdd Atletas " + e.Message);
            }
            return respuesta;
        }


        













        /// <summary>
        /// metodo para comprobar si un nombre esta repetido, pero he decidio no usarlo.
        /// </summary>
        /// <param name="nombre">Nombre del atleta.</param>
        /// <returns></returns>


        public static bool comprobarNombreAtleta()
        {


            string nombre = "Jorge";
            //string apellido = "Masvidal";

            bool respuesta=false;

            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "SELECT * FROM ATLETAS where IdAtleta  and NOMBRE=@nombre";
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Prepare();
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (!dataReader.Read())
                {
                    respuesta = true;
                }
                dataReader.Dispose();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al comprobar nombre " + e.Message);
            }

            return respuesta;

        }


        /// <summary>
        /// metodo para comprobar si el correo esta repetido, pero he decidio no usarlo.
        /// </summary>
        /// <param name="correo">Correo del atleta.</param>
        /// <returns></returns>


        public static bool comprobarCorreoRepetido(string correo)
        {
            bool respuesta = false;

            try
            {
                MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConexionMysql01"].ConnectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "SELECT * FROM ATLETAS  WHERE CORREO=@correo";
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Prepare();
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (!dataReader.Read())
                {
                    respuesta = true;
                }
                dataReader.Dispose();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al comprobar correo " + e.Message);
            }

            return respuesta;


        }
        



    }

    


    }



