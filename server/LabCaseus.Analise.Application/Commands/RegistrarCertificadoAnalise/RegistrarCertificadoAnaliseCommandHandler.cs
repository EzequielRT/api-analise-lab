using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Infra.Data.UoW;
using MediatR;

namespace LabCaseus.Analise.Application.Commands.RegistrarCertificadoAnalise
{
    public class RegistrarCertificadoAnaliseCommandHandler : CommandHandler,
       IRequestHandler<RegistrarCertificadoAnaliseCommand, bool>
    {
        private readonly IUnitOfWork _uow;

        public RegistrarCertificadoAnaliseCommandHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IUnitOfWork uow) : base(mediator, notifications)
        {
            _uow = uow;
        }

        public async Task<bool> Handle(RegistrarCertificadoAnaliseCommand request, CancellationToken cancellationToken)
        {
            await _uow.BeginTransactionAsync();

            var cliente = request.Cliente.ToEntity();
            await _uow.Clientes.AdicionarClienteAsync(cliente);
            await _uow.CompleteAsync();

            var farmaceuticoResponsavel = request.FarmaceuticoResponsavel.ToEntity();
            await _uow.CertificadosAnalises.AdicionarFarmaceuticoResponsavelAsync(farmaceuticoResponsavel);
            await _uow.CompleteAsync();

            var ph = request.AnaliseFisicoQuimica.Ph.ToEntity();
            await _uow.CertificadosAnalises.AdicionarPhAsync(ph);
            await _uow.CompleteAsync();

            var ferro = request.AnaliseFisicoQuimica.Ferro.ToEntity();
            await _uow.CertificadosAnalises.AdicionarFerroAsync(ferro);
            await _uow.CompleteAsync();

            var turbidez = request.AnaliseFisicoQuimica.Turbidez.ToEntity();
            await _uow.CertificadosAnalises.AdicionarTurbidezAsync(turbidez);
            await _uow.CompleteAsync();

            var cloreto = request.AnaliseFisicoQuimica.Cloreto.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCloretoAsync(cloreto);
            await _uow.CompleteAsync();

            var corAparente = request.AnaliseFisicoQuimica.CorAparente.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCorAparenteAsync(corAparente);
            await _uow.CompleteAsync();

            var aspectoVisual = request.AnaliseFisicoQuimica.AspectoVisual.ToEntity();
            await _uow.CertificadosAnalises.AdicionarAspectoVisualAsync(aspectoVisual);
            await _uow.CompleteAsync();

            var cloroResidualLivre = request.AnaliseFisicoQuimica.CloroResidualLivre.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCloroResidualLivreAsync(cloroResidualLivre);
            await _uow.CompleteAsync();

            var solidosTotaisDissolvidos = request.AnaliseFisicoQuimica.SolidosTotaisDissolvidos.ToEntity();
            await _uow.CertificadosAnalises.AdicionarSolidosTotaisDissolvidosAsync(solidosTotaisDissolvidos);
            await _uow.CompleteAsync();

            var coliformeTermotolerante = request.AnaliseMicrobiologica.ColiformeTermotolerante.ToEntity();
            await _uow.CertificadosAnalises.AdicionarColiformeTermotoleranteAsync(coliformeTermotolerante);
            await _uow.CompleteAsync();

            await _uow.CommitAsync();

            //request.SetCertificadoAnaliseUId();

            return true;
        }
    }
}