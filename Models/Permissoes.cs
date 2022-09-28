using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Permissoes
    {
        [Key]
        public int ID { get; set; }
        public int fk_Operador { get; set; }
        public int fk_Menu { get; set; }
        public int fk_Sub_Menu { get; set; }
        public bool Editar { get; set; }
        public bool Apagar { get; set; }
        public bool Imprimir { get; set; }
    }
}
