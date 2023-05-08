using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Application.DTOs
{
    public class CertificadoAnaliseViewModel
    {
        public CertificadoAnaliseViewModel(CertificadoAnalise entity)
        {
            CertificadoAnaliseUId = entity.UId;
            Numero = entity.Numero;
            Amostra = entity.Amostra;
            LocalColeta = entity.LocalColeta;
            DataHoraColeta = entity.DataHoraColeta;
            ResponsavelColeta = entity.ResponsavelColeta;
            FuncaoAgua = entity.FuncaoAgua;
            DataHoraRecebimentoCaseus = entity.DataHoraRecebimentoCaseus;
            DataHoraInicioAnalise = entity.DataHoraInicioAnalise;
            DataHoraTerminoAnalise = entity.DataHoraTerminoAnalise;
            ParecerFarmaceutico = entity.ParecerFarmaceutico;
            Cliente = new ClienteViewModel(entity.Cliente);
            FarmaceuticoResponsavel = new FarmaceuticoResponsavelViewModel(entity.FarmaceuticoResponsavel);
            AnaliseFisicoQuimica = new AnaliseFisicoQuimicaViewModel(entity.AnaliseFisicoQuimica);
            AnaliseMicrobiologica = new AnaliseMicrobiologicaViewModel(entity.AnaliseMicrobiologica);
            EspecificacaosMetodologiasAnalise = entity.EspecificacaosMetodologiasAnalise.Select(x => new EspecificacaoMetodologiaAnaliseViewModel(x)).ToList();
        }

        public Guid CertificadoAnaliseUId { get; private set; }
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

        public ClienteViewModel Cliente { get; private set; }
        public FarmaceuticoResponsavelViewModel FarmaceuticoResponsavel { get; private set; }
        public AnaliseFisicoQuimicaViewModel AnaliseFisicoQuimica { get; private set; }
        public AnaliseMicrobiologicaViewModel AnaliseMicrobiologica { get; private set; }
        public List<EspecificacaoMetodologiaAnaliseViewModel> EspecificacaosMetodologiasAnalise { get; private set; }

        public static CertificadoAnaliseViewModel FromEntity(CertificadoAnalise certificadoAnalise)
        {
            return new CertificadoAnaliseViewModel(certificadoAnalise);
        }
    }

    public class ClienteViewModel
    {
        public ClienteViewModel(Cliente cliente)
        {
            RazaoSocial = cliente.RazaoSocial;
            Cnpj = cliente.Cnpj;
            Endereco = cliente.Endereco;
        }

        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Endereco { get; private set; }
    }

    public class FarmaceuticoResponsavelViewModel
    {
        public FarmaceuticoResponsavelViewModel(Farmaceutico farmaceuticoResponsavel)
        {
            FarmaceuticoNome = farmaceuticoResponsavel.FarmaceuticoNome;
            FarmaceuticoEspecialidade = farmaceuticoResponsavel.FarmaceuticoEspecialidade;
            FarmaceuticoRegistroCrq = farmaceuticoResponsavel.FarmaceuticoRegistroCrq;
        }

        public string FarmaceuticoNome { get; private set; }
        public string FarmaceuticoEspecialidade { get; private set; }
        public string FarmaceuticoRegistroCrq { get; private set; }
    }

    public class AnaliseFisicoQuimicaViewModel
    {
        public AnaliseFisicoQuimicaViewModel(AnaliseFisicoQuimica entity)
        {
            Ph = new PhViewModel(entity.Ph);
            Ferro = new FerroViewModel(entity.Ferro);
            Turbidez = new TurbidezViewModel(entity.Turbidez);
            Cloreto = new CloretoViewModel(entity.Cloreto);
            CorAparente = new CorAparenteViewModel(entity.CorAparente);
            AspectoVisual = new AspectoVisualViewModel(entity.AspectoVisual);
            CloroResidualLivre = new CloroResidualLivreViewModel(entity.CloroResidualLivre);
            SolidosTotaisDissolvidos = new SolidosTotaisDissolvidosViewModel(entity.SolidosTotaisDissolvidos);
        }

        public PhViewModel Ph { get; set; }
        public FerroViewModel Ferro { get; set; }
        public TurbidezViewModel Turbidez { get; set; }
        public CloretoViewModel Cloreto { get; set; }
        public CorAparenteViewModel CorAparente { get; set; }
        public AspectoVisualViewModel AspectoVisual { get; set; }
        public CloroResidualLivreViewModel CloroResidualLivre { get; set; }
        public SolidosTotaisDissolvidosViewModel SolidosTotaisDissolvidos { get; set; }

        public class SolidosTotaisDissolvidosViewModel
        {
            public SolidosTotaisDissolvidosViewModel(SolidosTotaisDissolvidos entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class CloroResidualLivreViewModel
        {
            public CloroResidualLivreViewModel(CloroResidualLivre entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class AspectoVisualViewModel
        {
            public AspectoVisualViewModel(AspectoVisual entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class CorAparenteViewModel
        {
            public CorAparenteViewModel(CorAparente entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class CloretoViewModel
        {
            public CloretoViewModel(Cloreto entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class TurbidezViewModel
        {
            public TurbidezViewModel(Turbidez entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class FerroViewModel
        {
            public FerroViewModel(Ferro entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }

        public class PhViewModel
        {
            public PhViewModel(Ph entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }
    }

    public class AnaliseMicrobiologicaViewModel
    {
        public AnaliseMicrobiologicaViewModel(AnaliseMicrobiologica entity)
        {
            ColiformesTermotolerantes = new ColiformeTermotoleranteViewModel(entity.ColiformeTermotolerante);
        }

        public ColiformeTermotoleranteViewModel ColiformesTermotolerantes { get; set; }

        public class ColiformeTermotoleranteViewModel
        {
            public ColiformeTermotoleranteViewModel(ColiformeTermotolerante entity)
            {
                Especificacao = entity.Especificacao;
                Resultado = entity.Resultado;
            }

            public string Especificacao { get; private set; }
            public string Resultado { get; private set; }
        }
    }

    public class EspecificacaoMetodologiaAnaliseViewModel
    {
        public EspecificacaoMetodologiaAnaliseViewModel(EspecificacaoMetodologiaAnalise entity)
        {
            Descricao = entity.EspecificacaoMetodologia.Descricao;
        }

        public string Descricao { get; set; }
    }

}