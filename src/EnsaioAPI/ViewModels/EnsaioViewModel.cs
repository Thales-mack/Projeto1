namespace EnsaioAPI.ViewModels
{
    public class EnsaioViewModel
    {
        public int ClientId { get; set; }
        public Ensaio Ensaio { get; set; } = null!;

        public static Models.Ensaio ToEnsaio(EnsaioViewModel ensaioViewModel)
        {
            var ensaio = new Models.Ensaio()
            {
                ResistenciaIsolamento = Map(ensaioViewModel.Ensaio.ResistenciaIsolamento),
                ResistenciaOhmicaEnrolamentos = Map(ensaioViewModel.Ensaio.ResistenciaOhmicaEnrolamentos),
                Rotina = Map(ensaioViewModel.Ensaio.Rotina)
            };

            return ensaio;
        }

        private static Models.ResistenciaOhmicaEnrolamentos Map(ResistenciaOhmicaEnrolamentos resistenciaOhmicaEnrolamentos)
        {
            return new Models.ResistenciaOhmicaEnrolamentos()
            {
                EnrolTi = resistenciaOhmicaEnrolamentos.EnrolTi,
                EnrolTs = resistenciaOhmicaEnrolamentos.EnrolTs,
                H1h2 = resistenciaOhmicaEnrolamentos.H1h2,
                H1H3 = resistenciaOhmicaEnrolamentos.H1H3,
                H2H3 = resistenciaOhmicaEnrolamentos.H2H3,
                X1x2 = resistenciaOhmicaEnrolamentos.X1x2,
                X1x3 = resistenciaOhmicaEnrolamentos.X1x3,
                TemperaturaAmbiente = resistenciaOhmicaEnrolamentos.TemperaturaAmbiente,
                X2x3 = resistenciaOhmicaEnrolamentos.X2x3
            };
        }

        private static Models.Rotina Map(Rotina rotina)
        {
            return new Models.Rotina()
            {
                Fabricante = rotina.Fabricante,
                Fases = rotina.Fases,
                Frequencia = rotina.Frequencia,
                DataFabricacao = rotina.DataFabricacao,
                AtLigadaEmKv = rotina.AtLigadaEmKv,
                BtLigadaEmKv = rotina.BtLigadaEmKv,
                CorrentAt = rotina.CorrentAt,
                CorrentBt = rotina.CorrentBt,
                Derivacoes = rotina.Derivacoes,
                Estado = rotina.Estado,
                Ligacao = rotina.Ligacao,
                MassaKg =   rotina.MassaKg,
                Modelo = rotina.Modelo,
                Potencia = rotina.Potencia,
                RotinaId = rotina.RotinaId,
                TensaoAt =  rotina.TensaoAt,
                TensaoBt = rotina.TensaoBt,
                Tipo = rotina.Tipo,
            };
        }

        private static Models.ResistenciaIsolamento Map(ResistenciaIsolamento resistenciaIsolamento)
        {
            return new Models.ResistenciaIsolamento()
            {
                LeituraAtBt = resistenciaIsolamento.LeituraAtBt,
                LeituraAtMassa = resistenciaIsolamento.LeituraAtMassa,
                LeituraBtMassa = resistenciaIsolamento.LeituraAtBt,
                TensaoDoMegometro = resistenciaIsolamento.TensaoDoMegometro
            };
        }
    }

    public class Ensaio
    {
        public Rotina Rotina { get; set; } = null!;
        public ResistenciaOhmicaEnrolamentos ResistenciaOhmicaEnrolamentos { get; set; } = null!;
        public ResistenciaIsolamento ResistenciaIsolamento { get; set; } = null!;
    }

    public class Rotina
    {
        public int RotinaId { get; set; }
        public string? Potencia { get; set; }
        public string? Fases { get; set; }
        public string? Ligacao { get; set; }
        public string? Tipo { get; set; }
        public string? Modelo { get; set; }
        public string? Frequencia { get; set; }
        public string? TensaoAt { get; set; }
        public string? TensaoBt { get; set; }
        public string? Derivacoes { get; set; }
        public string? AtLigadaEmKv { get; set; }
        public string? BtLigadaEmKv { get; set; }
        public string? CorrentAt { get; set; }
        public string? CorrentBt { get; set; }
        public string? DataFabricacao { get; set; }
        public string? Estado { get; set; }
        public string? MassaKg { get; set; }
        public string? Fabricante { get; set; }
    }

    public class ResistenciaOhmicaEnrolamentos
    {
        public int ResistenciaOhmicaEnrolamentosId { get; set; }
        public string? H1h2 { get; set; }
        public string? H1H3 { get; set; }
        public string? H2H3 { get; set; }
        public string? EnrolTs { get; set; }
        public string? TemperaturaAmbiente { get; set; }
        public string? X1x2 { get; set; }
        public string? X1x3 { get; set; }
        public string? X2x3 { get; set; }
        public string? EnrolTi { get; set; }
    }

    public class ResistenciaIsolamento
    {
        public int ResistenciaIsolamentoId { get; set; }
        public string? LeituraAtBt { get; set; }
        public string? LeituraAtMassa { get; set; }
        public string? LeituraBtMassa { get; set; }
        public string? TensaoDoMegometro { get; set; }
    }
}
