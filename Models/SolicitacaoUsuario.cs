using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models
{
    public class SolicitacaoUsuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Setor { get; set; }
        [Required]
        public string Local { get; set; }
        [Required]
        public DateTime Data_Comeco { get; set; }
        [Required]
        public DateTime Data_Criacao { get; set; }
        [Required]
        public DateTime Data_Alteracao { get; set; }
        public int OperadorSolicitacao { get; set; }
        public bool Email { get; set; }
        public bool Compumate { get; set; }
        public bool NovaEstacao { get; set; }
        public bool SoftwarePadrao { get; set; }
        public bool SoftwareEspecial { get; set; }
        public bool AcessoInternet { get; set; }
        public bool AcessoPastas { get; set; }
        public bool Ramal { get; set; }
        public bool Skype { get; set; }
        public string Observacoes { get; set; }
        public int Status { get; set; }
    }
}
