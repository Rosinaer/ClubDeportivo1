using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            // Crear una instancia de GestionClubDeportivo
            GestionClubDeportivo miClub = new GestionClubDeportivo();

            // Crear una instancia de DateTime para la fecha de afiliaci�n
            DateTime FechaAfiliacion = DateTime.Today;

            // Agregar un socio
           miClub.altaSocio("Juan P�rez", "Belgica 1460", "juanperez@gmail.com", "socio", FechaAfiliacion);

            // Agregar un profesor
            Profesor nuevoProfesor = new Profesor("Mar�a Garc�a", "19hs");
            miClub.Profesores.Add(nuevoProfesor);

            // Crear una instancia de Actividad
            Actividad actividad = new Actividad("Nataci�n", 1500);
            miClub.Actividades.Add(actividad);

            // Obtener una instancia de la conexi�n
            Conexion miConexion = Conexion.getInstancia();

            // Obtener una conexi�n a la base de datos
            MySqlConnection conexion = miConexion.CrearConexion();

          

            try
            {
               
                // Abrir la conexi�n
                conexion.Open();

              //  Console.WriteLine("�Conexi�n exitosa a la base de datos!");
                MessageBox.Show("Hello �Conexi�n exitosa a la base de datos!");

                // Aqu� puedes realizar consultas o realizar otras operaciones en la base de datos

                DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
                Usuario dato = new Usuario(); // variable que contiene todas las caracteristicas de la clase
                tablaLogin = dato.Log_Usu("admin", "123");
                if (tablaLogin.Rows.Count > 0)
                {
                    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto");
                }





                // Cerrar la conexi�n
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);

            }
        }
    }
}
