using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Usuario
    {
        [Key]
        public int Operador { get; set; }
        public string Nome { get; set; }
        public int Admin { get; set; }
    }
}
