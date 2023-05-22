using LabCaseus.Analise.Application.DTOs;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarCertificadoAnalisePeloUId
{
    public class BuscarCertificadoAnalisePeloUIdQuery : IRequest<CertificadoAnaliseViewModel>
    {
        public BuscarCertificadoAnalisePeloUIdQuery(Guid certificadoAnaliseUId)
        {
            CertificadoAnaliseUId = certificadoAnaliseUId;
        }

        public Guid CertificadoAnaliseUId { get; set; }
    }
}