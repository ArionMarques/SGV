using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Campo de usuário é obrigatório")]
        public string CodUsuario { get; set; }

        [Required(ErrorMessage = "Campo de senha é obrigatório")]
        public string Senha { get; set; }
    }
}
