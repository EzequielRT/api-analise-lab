using LabCaseus.Analise.Application.DTOs;
using MediatR;

namespace LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise
{
    public class BuscarTodosCertificadosAnaliseQuery : IRequest<List<CertificadoAnaliseViewModel>>
    {
        private List<CertificadoAnaliseViewModel> _certificadoAnaliseViewModel { get; set; }
    }
}