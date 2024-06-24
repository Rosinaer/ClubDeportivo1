using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo1.Entidades;

namespace ClubDeportivo1.Datos
{
    public abstract class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Doc { get; set; }
        public string Contacto { get; set; }


        public Persona() { }

        protected Persona(string nombre, string apellido, int doc, string contacto)
        {
            Nombre = nombre;
            Apellido = apellido;
            Doc = doc;
            Contacto = contacto;
        }


        // Pago general
        public virtual void RealizarPago()
        {
            Console.WriteLine("Una persona realiza un pago");
        }
    }
}

