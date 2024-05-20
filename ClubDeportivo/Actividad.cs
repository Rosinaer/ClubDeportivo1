using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Actividad
    {
        private static int _contadorId = 0;

        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public float Costo { get; set; }
        public int Cupo { get; set; } // Cupo disponible para la actividad

        public Actividad(string nombre, float costo)
        {
            IdActividad = ++_contadorId;
            Nombre = nombre;
            Costo = costo;
            Cupo = 3;
        }
    }
}
