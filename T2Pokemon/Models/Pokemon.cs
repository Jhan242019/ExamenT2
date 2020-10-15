using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T2Pokemon.Models
{
    public class Pokemon
    {
       public int Id { get; set; }
       [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

       [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdTipo { get; set; }

        public string Imagen { get; set; }

        public int UserId { get; set; }

        public Elemento Elementos { get; set; }

        public List<Captura> Capturas { get; set; }
    }
}
