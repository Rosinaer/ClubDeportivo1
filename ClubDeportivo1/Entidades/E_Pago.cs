using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1.Entidades
{
    public class E_Pago
    {
        public int idPago { get; set; }
        public int idPers { get; set; }
        public decimal monto { get; set; }
        public DateTime fechaPago { get; set; }
        public string tipoPago { get; set; }
    }
}
