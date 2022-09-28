using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models.RecursosHumanos
{
    public class AlteracaoFuncional
    {
        [Key]
        public int Id { get; set; }
        public int SetorOrigem { get; set; }
        public int CargoOrigem { get; set; }
        public int FuncaoOrigem { get; set; }
        public int SetorDestino { get; set; }
        public int CargoDestino { get; set; }
        public int FuncaoDestino { get; set; }
        public int NomeFuncionario { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public int OperadorAutoriza { get; set; }
        public DateTime DataVistoRH { get; set; }
        public bool AlteracaoEfetivada { get; set; }
        public int OperadorRH { get; set; }
        public string Observacoes { get; set; }
        public int Status { get; set; }
    }
}
