using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1
{
    public class NoSocio : Datos.Persona
    {
        public decimal CuotaDiaria { get; set; }

        public override void RealizarPago()
        {
            // Paga la cuota Diaria
        }



    }
}
