using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Socio
    {
        private static int _contadorId = 0;

        public int IdSocio { get; set; }// Identificador único del socio
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Tipo { get; set; }// Tipo de miembro (socio o no socio)
        public DateTime FechaAfiliacion { get; set; }
        public Carnet Carnet { get; set; }
        internal List<Actividad> Actividades { get; set; } = new List<Actividad>(); // Lista de actividades en las que está inscrito el socio
        public Socio(string nombre, string direccion, string contacto, string tipo, DateTime FechaAfiliacion)
        {
            IdSocio = ++_contadorId;
            Nombre = nombre;
            Direccion = direccion;
            Apellido = Apellido;
            DNI = DNI;
            Contacto = contacto;
            Tipo = tipo;
            this.FechaAfiliacion = FechaAfiliacion;
            Carnet = new Carnet(IdSocio, DateTime.Today);
        }
    }
}
