using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Menus
    {
        [Key]
        public int Id { get; set; }
        public string Menu { get; set; }
    }
}
