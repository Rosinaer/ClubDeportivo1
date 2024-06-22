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
        private string Nombre;
        private string Apellido;
        private int Doc;
        private string Contacto;

        public Persona() { }


        // Pago general
        public abstract void RealizarPago();
    }
}

