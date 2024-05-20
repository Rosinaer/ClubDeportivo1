using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Profesor
    {
        private static int _contadorId = 0;

        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }

        public Profesor(string nombre, string horario)
        {
            IdProfesor = ++_contadorId;
            Nombre = nombre;
            Horario = horario;
        }
    }
}
