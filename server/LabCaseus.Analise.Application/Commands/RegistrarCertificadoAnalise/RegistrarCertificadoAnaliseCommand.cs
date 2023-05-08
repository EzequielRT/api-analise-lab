using LabCaseus.Analise.Application.Mediator.Message;
using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise
{
    public class RegistrarCertificadoAnaliseCommand : Command
    {
        public Guid CertificadoAnaliseUId { get; private set; }
        public string Numero { get; private set; }
        public string Amostra { get; set; }
        public string LocalColeta { get; set; }
        public DateTime DataHoraColeta { get; set; }
        public string ResponsavelColeta { get; set; }
        public string FuncaoAgua { get; set; }
        public DateTime DataHoraRecebimentoCaseus { get; set; }
        public DateTime DataHoraInicioAnalise { get; set; }
        public DateTime DataHoraTerminoAnalise { get; set; }
        public string ParecerFarmaceutico { get; set; }
        public ClienteInputModel Cliente { get; set; }
        public FarmaceuticoResponsavelInputModel FarmaceuticoResponsavel { get; set; }
        public AnaliseFisicoQuimicaInputModel AnaliseFisicoQuimica { get; set; }
        public AnaliseMicrobiologicaInputModel AnaliseMicrobiologica { get; set; }
        public int[] EspecificacoesMetodologiasAnaliseId { get; set; }

        public void SetCertificadoAnaliseUId(Guid certificadoAnaliseUId) => CertificadoAnaliseUId = certificadoAnaliseUId;
        public void SetNumero(string numero) => Numero = numero;

        public CertificadoAnalise ToEntity(
            int clienteId,
            int farmaceuticoResponsavelId)
        {
            return new CertificadoAnalise(
                Amostra,
                LocalColeta,
                DataHoraColeta,
                ResponsavelColeta,
                FuncaoAgua,
                DataHoraRecebimentoCaseus,
                DataHoraInicioAnalise,
                DataHoraTerminoAnalise,
                ParecerFarmaceutico,
                clienteId,
                farmaceuticoResponsavelId);
        }
    }

    public class AnaliseFisicoQuimicaInputModel
    {
        public PhInputModel Ph { get; set; }
        public FerroInputModel Ferro { get; set; }
        public TurbidezInputModel Turbidez { get; set; }
        public CloretoInputModel Cloreto { get; set; }
        public CorAparenteInputModel CorAparente { get; set; }
        public AspectoVisualInputModel AspectoVisual { get; set; }
        public CloroResidualLivreInputModel CloroResidualLivre { get; set; }
        public SolidosTotaisDissolvidosInputModel SolidosTotaisDissolvidos { get; set; }

        public class SolidosTotaisDissolvidosInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public SolidosTotaisDissolvidos ToEntity()
            {
                return new SolidosTotaisDissolvidos(Especificacao, Resultado);
            }
        }

        public class CloroResidualLivreInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public CloroResidualLivre ToEntity()
            {
                return new CloroResidualLivre(Especificacao, Resultado);
            }
        }

        public class AspectoVisualInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public AspectoVisual ToEntity()
            {
                return new AspectoVisual(Especificacao, Resultado);
            }
        }

        public class CorAparenteInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public CorAparente ToEntity()
            {
                return new CorAparente(Especificacao, Resultado);
            }
        }

        public class CloretoInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public Cloreto ToEntity()
            {
                return new Cloreto(Especificacao, Resultado);
            }
        }

        public class TurbidezInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public Turbidez ToEntity()
            {
                return new Turbidez(Especificacao, Resultado);
            }
        }

        public class FerroInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public Ferro ToEntity()
            {
                return new Ferro(Especificacao, Resultado);
            }
        }

        public class PhInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public Ph ToEntity()
            {
                return new Ph(Especificacao, Resultado);
            }
        }
    }

    public class AnaliseMicrobiologicaInputModel
    {
        public ColiformeTermotoleranteInputModel ColiformesTermotolerantes { get; set; }

        public class ColiformeTermotoleranteInputModel
        {
            public string Especificacao { get; set; }
            public string Resultado { get; set; }

            public ColiformeTermotolerante ToEntity()
            {
                return new ColiformeTermotolerante(Especificacao, Resultado);
            }
        }
    }

    public class ClienteInputModel
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }

        public Cliente ToEntity()
        {
            return new Cliente(RazaoSocial, Cnpj, Endereco);
        }
    }

    public class FarmaceuticoResponsavelInputModel
    {
        public string FarmaceuticoNome { get; set; }
        public string FarmaceuticoEspecialidade { get; set; }
        public string FarmaceuticoRegistroCrq { get; set; }

        public FarmaceuticoResponsavel ToEntity()
        {
            return new FarmaceuticoResponsavel(FarmaceuticoNome, FarmaceuticoEspecialidade, FarmaceuticoRegistroCrq);
        }
    }
}