using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class Cuota
    {
        public int IdCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public float Monto { get; set; }
        public string Estado { get; set; }

        public Cuota(DateTime fechaPago, float monto, string estado)
        {
            FechaPago = fechaPago;
            Monto = monto;
            Estado = estado;
        }
    }
}
