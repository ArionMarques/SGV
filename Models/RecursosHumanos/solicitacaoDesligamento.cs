using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models.RecursosHumanos
{
    public class solicitacaoDesligamento
    {
        public int id { get; set; }
        public int Setor { get; set; }
        public int nomeColaborador { get; set; }
        public int motivo { get; set; }
        public DateTime dataSolicitacao { get; set; }
        public DateTime dataDesligamento { get; set; }
        public int usuarioSolicitacao { get; set; }
        public int Status { get; set; }
        public int usuarioAlteracao { get; set; }
    }
}
