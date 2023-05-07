using LabCaseus.Analise.Domain.ValueObjects;

namespace LabCaseus.Analise.Domain.Entities
{
    public class EspecificacaoMetodologiaAnalise : Base
    {
        public EspecificacaoMetodologiaAnalise(int certificadoAnaliseId, int especificacaoMetodologiaId)
        {
            CertificadoAnaliseId = certificadoAnaliseId;
            EspecificacaoMetodologiaId = especificacaoMetodologiaId;
        }

        public EspecificacaoMetodologiaAnalise(int id, int certificadoAnaliseId, int especificacaoMetodologiaId)
        {
            Id = id;
            CertificadoAnaliseId = certificadoAnaliseId;
            EspecificacaoMetodologiaId = especificacaoMetodologiaId;
        }

        public int Id { get; private set; }

        public int CertificadoAnaliseId { get; private set; }
        public virtual CertificadoAnalise CertificadoAnalise { get; set; }

        public int EspecificacaoMetodologiaId { get; private set; }
        public virtual EspecificacaoMetodologia EspecificacaoMetodologia { get; set; }
    }
}