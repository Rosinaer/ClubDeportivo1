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
 
        public  NoSocio(decimal CuotaDiaria) : base()
        {
            this.CuotaDiaria = CuotaDiaria;           

        }
        public override void RealizarPago()
        {
            // Paga la cuota Diaria de la actividad que realize
        }



    }
}
