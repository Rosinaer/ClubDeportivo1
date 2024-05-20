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

            // Crear una instancia de DateTime para la fecha de afiliación
            DateTime FechaAfiliacion = DateTime.Today;

            // Agregar un socio
            miClub.altaSocio("Juan Pérez", "Belgica 1460", "juanperez@gmail.com", "socio", FechaAfiliacion);

            // Agregar un profesor
            Profesor nuevoProfesor = new Profesor("María García", "19hs");
            miClub.Profesores.Add(nuevoProfesor);

            // Crear una instancia de Actividad
            Actividad actividad = new Actividad("Natación", 1500);
            miClub.Actividades.Add(actividad);

            // Obtener una instancia de la conexión
            Conexion miConexion = Conexion.getInstancia();

            // Obtener una conexión a la base de datos
            MySqlConnection conexion = miConexion.CrearConcexion();

            try
            {
                // Abrir la conexión
                conexion.Open();

                Console.WriteLine("¡Conexión exitosa a la base de datos!");

                // Aquí puedes realizar consultas o realizar otras operaciones en la base de datos

                // Cerrar la conexión
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
