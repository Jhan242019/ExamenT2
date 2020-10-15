using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T2Pokemon.Models
{
    public class Captura
    {
        public int Id { get; set ;}
        public int IdUsuario { get; set; }
        public int IdPokemon { get; set; }
        public DateTime FechaCaptura { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
