using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Sub_Setor
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
    }
}
