namespace LabCaseus.Analise.Domain.Entities
{
    public class CertificadoAnalise : Base
    {
        public CertificadoAnalise(
            string amostra,
            string localColeta,
            DateTime dataHoraColeta,
            string responsavelColeta,
            string funcaoAgua,
            DateTime dataHoraRecebimentoCaseus,
            DateTime dataHoraInicioAnalise,
            DateTime dataHoraTerminoAnalise,
            string parecerFarmaceutico,
            int clienteId,
            int farmaceuticoResponsavelId)
        {
            Amostra = amostra;
            LocalColeta = localColeta;
            DataHoraColeta = dataHoraColeta;
            ResponsavelColeta = responsavelColeta;
            FuncaoAgua = funcaoAgua;
            DataHoraRecebimentoCaseus = dataHoraRecebimentoCaseus;
            DataHoraInicioAnalise = dataHoraInicioAnalise;
            DataHoraTerminoAnalise = dataHoraTerminoAnalise;
            ParecerFarmaceutico = parecerFarmaceutico;
            ClienteId = clienteId;
            FarmaceuticoResponsavelId = farmaceuticoResponsavelId;
        }

        public CertificadoAnalise(
            int id,
            string amostra,
            string localColeta,
            DateTime dataHoraColeta,
            string responsavelColeta,
            string funcaoAgua,
            DateTime dataHoraRecebimentoCaseus,
            DateTime dataHoraInicioAnalise,
            DateTime dataHoraTerminoAnalise,
            string parecerFarmaceutico,
            int clienteId,
            int farmaceuticoResponsavelId)
        {
            Id = id;
            Amostra = amostra;
            LocalColeta = localColeta;
            DataHoraColeta = dataHoraColeta;
            ResponsavelColeta = responsavelColeta;
            FuncaoAgua = funcaoAgua;
            DataHoraRecebimentoCaseus = dataHoraRecebimentoCaseus;
            DataHoraInicioAnalise = dataHoraInicioAnalise;
            DataHoraTerminoAnalise = dataHoraTerminoAnalise;
            ParecerFarmaceutico = parecerFarmaceutico;
            ClienteId = clienteId;
            FarmaceuticoResponsavelId = farmaceuticoResponsavelId;

            EspecificacaosMetodologiasAnalise = new List<EspecificacaoMetodologiaAnalise>();
        }

        public int Id { get; private set; }

        public string Numero { get; private set; }
        public string Amostra { get; private set; }
        public string LocalColeta { get; private set; }
        public DateTime DataHoraColeta { get; private set; }
        public string ResponsavelColeta { get; private set; }
        public string FuncaoAgua { get; private set; }
        public DateTime DataHoraRecebimentoCaseus { get; private set; }
        public DateTime DataHoraInicioAnalise { get; private set; }
        public DateTime DataHoraTerminoAnalise { get; private set; }
        public string ParecerFarmaceutico { get; private set; }

        public int ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set; }

        public int FarmaceuticoResponsavelId { get; private set; }
        public virtual FarmaceuticoResponsavel FarmaceuticoResponsavel { get; set; }

        public virtual AnaliseFisicoQuimica AnaliseFisicoQuimica { get; set; }
        public virtual AnaliseMicrobiologica AnaliseMicrobiologica { get; set; }
        public virtual List<EspecificacaoMetodologiaAnalise> EspecificacaosMetodologiasAnalise { get; set; }
    }
}