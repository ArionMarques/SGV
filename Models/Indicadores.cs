using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Indicadores
    {
        [Key]
        public int Id { get; set; }
        public string IQ { get; set; }
        public int Mes { get; set; }
        public double Valor { get; set; }
    }
}
