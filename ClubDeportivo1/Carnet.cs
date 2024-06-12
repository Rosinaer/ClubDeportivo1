using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
{
    internal class Carnet
    {
        public int Numero { get; set; } // Número del carnet, que será igual al ID del socio
        public DateTime FechaEmision { get; set; }

        public Carnet(int numero, DateTime fechaEmision)
        {
            this.Numero = numero;
            this.FechaEmision = fechaEmision;
        }
    }
}
