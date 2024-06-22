using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1.Datos
{
    internal class Pago
    {
        public int Id {get; set;}
        public DateTime fechaPago { get; set;}  
        public decimal montoPagado {  get; set;}
        public int idCuota { get; set;}
        public Cuota cuota { get; set;}
        
    }
}
