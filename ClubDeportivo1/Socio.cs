using ClubDeportivo1.Datos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace ClubDeportivo1
{
    public class Socio : Datos.Persona
    {
                
        private static int _contadorId = 0;
    
        public int IdSocio { get; set; }// Identificador único del socio
        //public int IdPers {get; set; }

        // public string AptoFisico { get; set; }
    
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public int DNI { get; set; }
        //public string Direccion { get; set; }
        //public string Contacto { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        public int CarnetID { get; set; }
        internal List<Actividad> Actividades { get; set; } = new List<Actividad>(); // Lista de actividades en las que está inscrito el socio
        internal List<Pago> Pagos { get; set; } = new List<Pago>();
        public Socio() { }

        public Socio(int IdSocio,DateTime FechaAfiliacion, int CarnetID) :base()
        {
            this.IdSocio = ++_contadorId;
            
            this.FechaAfiliacion = DateTime.Today;
            this.CarnetID = CarnetID;

        }


       
        // Metodos
        public override void RealizarPago()
        {
            // El socio Paga la cuota Mensual
            
            
            //DateTime fechaUltimoPago;
            //DateTime fechaActual = DateTime.Now;
            

        //    if (fechaUltimoPago != null && (fechaActual - fechaUltimoPago.Value).TotalDays > 30)
        //    {
        //        Console.WriteLine("La cuota está vencida. No se puede realizar el pago.");
        //    }
        //    else
        //    {
        //        Pago nuevoPago = new Pago(fechaActual, monto);
        //        Pagos.Add(nuevoPago);
        //        Console.WriteLine($"Pago de {monto:C} realizado el {nuevoPago.Fechapago}.");
        //    }

        //}

        //// Método para obtener la fecha del último pago
        //private DateTime ObtenerFechaUltimoPago()
        //{
        //    if (Pagos.Count == 0)
        //        return null;

        //    return Pagos.Max(p => p.Fechapago);
        //}
    }
    }
}
