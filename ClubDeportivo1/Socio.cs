using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
{
    public class Socio : Datos.Persona
    {

        
        private static int _contadorId = 0;
    

        public int IdSocio { get; set; }// Identificador único del socio
        //public int IdPers {get; set; }


        // public string AptoFisico { get; set; }
        // public int CarnetID { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        internal List<Actividad> Actividades { get; set; } = new List<Actividad>(); // Lista de actividades en las que está inscrito el socio


        public Socio() { }

        public Socio(string nombre, string apellido, string direccion, int dni, string contacto)
        {
            this.IdSocio = ++_contadorId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.DNI = dni;
            this.Contacto = contacto;
            this.FechaAfiliacion = DateTime.Today;
        }

        // Metodos
        public override void RealizarPago()
        {
            // Paga la cuota Mensual
        }
    }
}
