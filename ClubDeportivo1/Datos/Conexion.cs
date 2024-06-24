﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubDeportivo1.Datos
{
    public class Conexion
    {
        // declaramos las variables 
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;
        private Conexion() // asignamos valores a las variables de la conexion

        {
            //bool correcto = false;
            //int mensaje;

            //string T_servidor = "Servidor";
            //string T_puerto = "Puerto";
            //string T_usuario = "Usuario";
            //string T_clave = "Clave";

            this.baseDatos = "proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";

            //while (correcto != true)
            //{
            //    // Armamos los cuadros de dialogo para el ingreso de datos
            //    T_servidor = Microsoft.VisualBasic.Interaction.InputBox
            //    ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
            //    T_puerto = Microsoft.VisualBasic.Interaction.InputBox
            //    ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
            //    T_usuario = Microsoft.VisualBasic.Interaction.InputBox
            //    ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
            //    T_clave = Microsoft.VisualBasic.Interaction.InputBox
            //    ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");


            //    mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
            //    T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
            //    T_usuario + " CLAVE: " + T_clave,
            //    "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);
            //    if (mensaje != 6)  // el valor 6 corresponde al SI
            //    {
            //        MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
            //        correcto = false;
            //    }
            //    else
            //    {
            //        correcto = true;
            //    }
            //}

            //this.baseDatos = "proyecto";
            //this.servidor = T_servidor;    // "localhost";
            //this.puerto = T_puerto;       //"3306";
            //this.usuario = T_usuario;
            //this.clave = T_clave;
        }
            // proceso de interacción
            public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave + 
                ";Database=" + this.baseDatos;

                //MessageBox.Show("Conexion exitosa", "MENSAJES DEL SISTEMA",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de conexion", "MENSAJES DEL SISTEMA",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Console.WriteLine("Error: " + ex.Message);
                cadena = null;

                throw ex;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}
