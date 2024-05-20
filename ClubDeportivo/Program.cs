using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Application.Run(new Form1());

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
            MySqlConnection conexion = miConexion.CrearConcexion();

            try
            {
                // Abrir la conexi�n
                conexion.Open();

                Console.WriteLine("�Conexi�n exitosa a la base de datos!");

                // Aqu� puedes realizar consultas o realizar otras operaciones en la base de datos

                // Cerrar la conexi�n
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
