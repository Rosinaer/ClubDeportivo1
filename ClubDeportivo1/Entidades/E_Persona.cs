using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1.Entidades
{
    public class E_Persona
    {
        public int idPers { get; set; }
        public string NombreP { get; set; }
        public string ApellidoP { get; set; }
        public int DocP { get; set; }
        public string DireccionP { get; set; }
        public string ContactoP { get; set; }
        public string TipoP { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
