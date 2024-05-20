using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Carnet
    {
        public int Numero { get; set; } // Número del carnet, que será igual al ID del socio
        public DateTime FechaEmision { get; set; }

        public Carnet(int numero, DateTime fechaEmision)
        {
            Numero = numero;
            FechaEmision = fechaEmision;
        }
    }
}
