using LabCaseus.Analise.Application.Mediator.Message;
using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise
{
    public class RegistrarCertificadoAnaliseCommand : Command
    {
        public string Numero { get; set; }
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

        public PhInputModel PhInputModel { get; set; }
        public FerroInputModel FerroInputModel { get; set; }
        public TurbidezInputModel TurbidezInputModel { get; set; }
        public CloretoInputModel CloretoInputModel { get; set; }
        public CorAparenteInputModel CorAparenteInputModel { get; set; }
        public AspectoVisualInputModel AspectoVisualInputModel { get; set; }
        public CloroResidualLivreInputModel CloroResidualLivreInputModel { get; set; }
        public SolidosTotaisDissolvidosInputModel SolidosTotaisDissolvidosInputModel { get; set; }
        public ColiformeTermotoleranteInputModel ColiformeTermotoleranteInputModel { get; set; }
        public int[] EspecificacaoMetodologiaAnalise { get; set; }
    }

    public class ColiformeTermotoleranteInputModel
    {
        public string Especificacao { get; set; }
        public string Resultado { get; set; }

        public ColiformeTermotolerante ToEntity()
        {
            return new ColiformeTermotolerante(Especificacao, Resultado);
        }
    }

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