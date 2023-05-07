namespace LabCaseus.Analise.Domain.Entities
{
    public class CertificadoAnalise : Base
    {
        public CertificadoAnalise(
            string numero,
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
            int farmaceuticoResponsavelId,
            int analiseFisicoQuimicaId,
            int analiseMicrobiologicaId)
        {
            Numero = numero;
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
            AnaliseFisicoQuimicaId = analiseFisicoQuimicaId;
            AnaliseMicrobiologicaId = analiseMicrobiologicaId;
        }

        public CertificadoAnalise(
            int id,
            string numero,
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
            int farmaceuticoResponsavelId,
            int analiseFisicoQuimicaId,
            int analiseMicrobiologicaId)
        {
            Id = id;
            Numero = numero;
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
            AnaliseFisicoQuimicaId = analiseFisicoQuimicaId;
            AnaliseMicrobiologicaId = analiseMicrobiologicaId;

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

        public int AnaliseFisicoQuimicaId { get; private set; }
        public virtual AnaliseFisicoQuimica AnaliseFisicoQuimica { get; set; }

        public int AnaliseMicrobiologicaId { get; private set; }
        public virtual AnaliseMicrobiologica AnaliseMicrobiologica { get; set; }

        public virtual List<EspecificacaoMetodologiaAnalise> EspecificacaosMetodologiasAnalise { get; set; }
    }
}