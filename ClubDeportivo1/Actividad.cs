using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
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
            this.IdActividad = ++_contadorId;
            this.Nombre = nombre;
            this.Costo = costo;
            this.Cupo = 3;
        }
    }
}
