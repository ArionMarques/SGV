using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Models.RecursosHumanos
{
    public class solicitacaoTreinamento
    {
        public int id { get; set; }
        public int NomeFuncionario { get; set; }
        public int Setor { get; set; }
        public string TempoEmpresa { get; set; }
        public int Cargo { get; set; }
        public string Curso { get; set; }
        public string Entidade { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public DateTime Horario { get; set; }
        public string Justificativa { get; set; }
        public DateTime DataCriacao { get; set; }
        public int UsuarioSolicitacao { get; set; }
        public string AbsenteismoColaborador { get; set; }
        public string Observacoes { get; set; }
        public double CustosInscricao { get; set; }
        public double CustosAlimentacao { get; set; }
        public double CustosDeslocamento { get; set; }
        public double CustosHospedagem { get; set; }
        public double CustosOutros { get; set; }
        public double CustosTotal { get; set; }
        public Boolean Aprovado { get; set; }
        public double PercentualAuxilio { get; set; }
        public DateTime DataAprovacao { get; set; }
        public int UsuarioAprovacao { get; set; }
        public Boolean Disseminacao { get; set; }
        public int metodoDisseminacao { get; set; }
    }
}
