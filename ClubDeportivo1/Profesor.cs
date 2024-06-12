using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
{
    internal class Profesor
    {
        private static int _contadorId = 0;

        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }

        public Profesor(string nombre, string horario)
        {
            this.IdProfesor = ++_contadorId;
            this.Nombre = nombre;
            this.Horario = horario;
        }
    }
}
