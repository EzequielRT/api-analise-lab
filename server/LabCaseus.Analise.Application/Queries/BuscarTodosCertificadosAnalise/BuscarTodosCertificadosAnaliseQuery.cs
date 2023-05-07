using LabCaseus.Analise.Application.DTOs;
using LabCaseus.Analise.Application.Mediator.Message;

namespace LabCaseus.Analise.Application.Queries.BuscarTodosCertificadosAnalise
{
    public class BuscarTodosCertificadosAnaliseQuery : Command
    {
        private List<CertificadoAnaliseViewModel> _certificadoAnaliseViewModel { get; set; }
        public void SetResponse(List<CertificadoAnaliseViewModel> certificadoAnaliseViewModel)
            => _certificadoAnaliseViewModel = certificadoAnaliseViewModel;
        public List<CertificadoAnaliseViewModel> GetResponse() => _certificadoAnaliseViewModel;
    }
}