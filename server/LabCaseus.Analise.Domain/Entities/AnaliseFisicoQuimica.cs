using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Domain.Entities
{
    public class AnaliseFisicoQuimica : Base
    {
        public AnaliseFisicoQuimica(
            int phId,
            int ferroId,
            int turbidezId,
            int cloretoId,
            int corAparenteId,
            int aspectoVisualId,
            int cloroResidualLivreId,
            int solidosTotaisDissolvidosId,
            int certificadoAnaliseId)
        {
            PhId = phId;
            FerroId = ferroId;
            TurbidezId = turbidezId;
            CloretoId = cloretoId;
            CorAparenteId = corAparenteId;
            AspectoVisualId = aspectoVisualId;
            CloroResidualLivreId = cloroResidualLivreId;
            SolidosTotaisDissolvidosId = solidosTotaisDissolvidosId;
            CertificadoAnaliseId = certificadoAnaliseId;
        }

        public AnaliseFisicoQuimica(
            int id,
            int phId,
            int ferroId,
            int turbidezId,
            int cloretoId,
            int corAparenteId,
            int aspectoVisualId,
            int cloroResidualLivreId,
            int solidosTotaisDissolvidosId,
            int certificadoAnaliseId)
        {
            Id = id;
            PhId = phId;
            FerroId = ferroId;
            TurbidezId = turbidezId;
            CloretoId = cloretoId;
            CorAparenteId = corAparenteId;
            AspectoVisualId = aspectoVisualId;
            CloroResidualLivreId = cloroResidualLivreId;
            SolidosTotaisDissolvidosId = solidosTotaisDissolvidosId;
            CertificadoAnaliseId = certificadoAnaliseId;
        }

        public int Id { get; private set; }

        public int PhId { get; private set; }
        public virtual Ph Ph { get; set; }

        public int FerroId { get; private set; }
        public virtual Ferro Ferro { get; set; }

        public int TurbidezId { get; private set; }
        public virtual Turbidez Turbidez { get; set; }

        public int CloretoId { get; private set; }
        public virtual Cloreto Cloreto { get; set; }

        public int CorAparenteId { get; private set; }
        public virtual CorAparente CorAparente { get; set; }

        public int AspectoVisualId { get; private set; }
        public virtual AspectoVisual AspectoVisual { get; set; }

        public int CloroResidualLivreId { get; private set; }
        public virtual CloroResidualLivre CloroResidualLivre { get; set; }

        public int SolidosTotaisDissolvidosId { get; private set; }
        public virtual SolidosTotaisDissolvidos SolidosTotaisDissolvidos { get; set; }

        public int CertificadoAnaliseId { get; private set; }
        public virtual CertificadoAnalise CertificadoAnalise { get; set; }
    }
}