using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Softwares
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Validade { get; set; }
        public string Responsavel { get; set; }
        public string Finalidade { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
    }
}
