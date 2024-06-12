using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
{
    internal class Cuota
    {
        public int IdCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public float Monto { get; set; }
        public string Estado { get; set; }

        public Cuota(DateTime fechaPago, float monto, string estado)
        {
            this.FechaPago = fechaPago;
            this.Monto = monto;
            this.Estado = estado;
        }
    }
}
