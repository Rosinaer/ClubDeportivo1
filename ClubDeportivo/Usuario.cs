using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public TipoUsuario Tipo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? UltimoInicioSesion { get; set; } // Puede ser nulo si el usuario nunca ha iniciado sesión

        // Constructor
        public Usuario()
        {
            FechaRegistro = DateTime.Now;
            Activo = true;
        }
        public enum TipoUsuario
        {
            Admin,
            Usuario
        }

    }
}
