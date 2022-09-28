using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class RNC
    {
        [Key]
        public int ID { get; set; }
        public int Setor { get; set; }
        public int Origem { get; set; }
        public int Acao { get; set; }
        public int Auditoria { get; set; }
        public int OperadorInclusao { get; set; }
        public int Produto { get; set; }
        public string  Motivo { get; set; }
    }
}
