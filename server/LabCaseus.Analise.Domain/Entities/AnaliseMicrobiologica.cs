using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Domain.Entities
{
    public class AnaliseMicrobiologica : Base
    {
        public AnaliseMicrobiologica(int coliformeTermotoleranteId, int certificadoAnaliseId)
        {
            ColiformeTermotoleranteId = coliformeTermotoleranteId;
            CertificadoAnaliseId = certificadoAnaliseId;
        }

        public AnaliseMicrobiologica(int id, int coliformeTermotoleranteId, int certificadoAnaliseId)
        {
            Id = id;
            ColiformeTermotoleranteId = coliformeTermotoleranteId;
            CertificadoAnaliseId = certificadoAnaliseId;
        }

        public int Id { get; private set; }

        public int ColiformeTermotoleranteId { get; private set; }
        public ColiformeTermotolerante ColiformeTermotolerante { get; set; }

        public int CertificadoAnaliseId { get; private set; }
        public virtual CertificadoAnalise CertificadoAnalise { get; set; }
    }
}