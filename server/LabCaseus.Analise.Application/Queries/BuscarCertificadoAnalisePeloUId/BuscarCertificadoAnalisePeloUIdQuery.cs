using LabCaseus.Analise.Application.DTOs;
using LabCaseus.Analise.Application.Mediator.Message;

namespace LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId
{
    public class BuscarCertificadoAnalisePeloUIdQuery : Command
    {
        public BuscarCertificadoAnalisePeloUIdQuery(Guid certificadoAnaliseUId)
        {
            CertificadoAnaliseUId = certificadoAnaliseUId;
        }

        public Guid CertificadoAnaliseUId { get; set; }

        private CertificadoAnaliseViewModel _certificadoAnalise { get; set; }
        public void SetResponse(CertificadoAnaliseViewModel certificadoAnalise) => _certificadoAnalise = certificadoAnalise;
        public CertificadoAnaliseViewModel GetResponse() => _certificadoAnalise;
    }
}