using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1.Datos
{
    internal class Pago
    {
        public DateTime Fechapago {  get; set; }        
        public decimal Monto {  get; set;}       
        public Cuota cuota { get; set;}


        public Pago(DateTime fecha, decimal monto, Cuota cuota)
        {
            Fechapago = fecha;
            Monto = monto;
            
        }

        public DateTime ProximaFechaDePago(DateTime fechaPago)
        {
            return fechaPago.AddDays(30);
        }

    }




}
