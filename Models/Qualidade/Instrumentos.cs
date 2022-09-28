using System;

namespace SGV.Models.Qualidade
{
    public class Instrumentos
    {
        public int idInstrumentos { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public string Capacidade { get; set; }
        public int Situacao { get; set; }
        public DateTime DataCalibracao { get; set; }
        public int CriterioAceitacao { get; set; }
        public int SituacaoAposCalibracao { get; set; }
        public int NumeroLaudo { get; set; }
        public int Frequencia { get; set; }
        public DateTime ProximaCalibracao { get; set; }
        public string LocalUsuario { get; set; }
        public int Tipo { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int CalibracaoInstrumentos { get; set; }
    }
}
