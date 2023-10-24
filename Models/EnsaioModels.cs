using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnsaioApp.Models
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; } = 0;

        public string ClienteName { get; set; }
        public ICollection<Ensaio> Ensaios { get; set; }
    }

    public class Ensaio
    {
        public int EnsaioId { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public Rotina Rotina { get; set; }

        public ResistenciaOhmicaEnrolamentos ResistenciaOhmicaEnrolamentos { get; set; }

        public ResistenciaIsolamento ResistenciaIsolamento { get; set; }
    }

    public class Rotina
    {
        public int RotinaId { get; set; }
        public string Potencia { get; set; }
        public string Fases { get; set; }
        public string Ligacao { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Frequencia { get; set; }
        public string TensaoAt { get; set; }
        public string TensaoBt { get; set; }
        public string Derivacoes { get; set; }
        public string AtLigadaEmKv { get; set; }
        public string BtLigadaEmKv { get; set; }
        public string CorrentAt { get; set; }
        public string CorrentBt { get; set; }
        public string DataFabricacao { get; set; }
        public string Estado { get; set; }
        public string MassaKg { get; set; }
        public string Fabricante { get; set; }

        public int EnsaioId { get; set; }
        public virtual Ensaio Ensaio { get; set; }
    }

    public class ResistenciaOhmicaEnrolamentos
    {
        public int ResistenciaOhmicaEnrolamentosId { get; set; }
        public string H1h2 { get; set; }
        public string H1H3 { get; set; }
        public string H2H3 { get; set; }
        public string EnrolTs { get; set; }
        public string TemperaturaAmbiente { get; set; }
        public string X1x2 { get; set; }
        public string X1x3 { get; set; }
        public string X2x3 { get; set; }
        public string EnrolTi { get; set; }

        public int EnsaioId { get; set; }
        public virtual Ensaio Ensaio { get; set; }
    }

    public class ResistenciaIsolamento
    {
        public int ResistenciaIsolamentoId { get; set; }
        public string LeituraAtBt { get; set; }
        public string LeituraAtMassa { get; set; }
        public string LeituraBtMassa { get; set; }
        public string TensaoDoMegometro { get; set; }

        public int EnsaioId { get; set; }
        public virtual Ensaio Ensaio { get; set; }
    }
}
