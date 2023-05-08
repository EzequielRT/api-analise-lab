using LabCaseus.Analise.Application.Mediator;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Domain.Entities;
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
            await _uow.BeginTransactionAsync(cancellationToken);

            var ph = request.AnaliseFisicoQuimica.Ph.ToEntity();
            await _uow.CertificadosAnalises.AdicionarPhAsync(ph, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var ferro = request.AnaliseFisicoQuimica.Ferro.ToEntity();
            await _uow.CertificadosAnalises.AdicionarFerroAsync(ferro, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var turbidez = request.AnaliseFisicoQuimica.Turbidez.ToEntity();
            await _uow.CertificadosAnalises.AdicionarTurbidezAsync(turbidez, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var cloreto = request.AnaliseFisicoQuimica.Cloreto.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCloretoAsync(cloreto, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var corAparente = request.AnaliseFisicoQuimica.CorAparente.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCorAparenteAsync(corAparente, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var aspectoVisual = request.AnaliseFisicoQuimica.AspectoVisual.ToEntity();
            await _uow.CertificadosAnalises.AdicionarAspectoVisualAsync(aspectoVisual, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var cloroResidualLivre = request.AnaliseFisicoQuimica.CloroResidualLivre.ToEntity();
            await _uow.CertificadosAnalises.AdicionarCloroResidualLivreAsync(cloroResidualLivre, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var solidosTotaisDissolvidos = request.AnaliseFisicoQuimica.SolidosTotaisDissolvidos.ToEntity();
            await _uow.CertificadosAnalises.AdicionarSolidosTotaisDissolvidosAsync(solidosTotaisDissolvidos, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var coliformeTermotolerante = request.AnaliseMicrobiologica.ColiformesTermotolerantes.ToEntity();
            await _uow.CertificadosAnalises.AdicionarColiformeTermotoleranteAsync(coliformeTermotolerante, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            var certificadoAnalise = request.ToEntity(request.ClienteId, request.FarmaceuticoResponsavelId);
            await _uow.CertificadosAnalises.AdicionarAsync(certificadoAnalise, cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            await _uow.CertificadosAnalises.VincularAnaliseFisicoQuimicaAsync(new AnaliseFisicoQuimica(
                ph.Id,
                ferro.Id,
                turbidez.Id,
                cloreto.Id,
                corAparente.Id,
                aspectoVisual.Id,
                cloroResidualLivre.Id,
                solidosTotaisDissolvidos.Id,
                certificadoAnalise.Id), cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            await _uow.CertificadosAnalises.VincularAnaliseMicrobiologicaAsync(new AnaliseMicrobiologica(
                coliformeTermotolerante.Id,
                certificadoAnalise.Id),cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            await _uow.CertificadosAnalises.VincularEspecificacoesMetodologiasAnaliseAsync(request
                .EspecificacoesMetodologiasAnaliseId
                .Select(x => new EspecificacaoMetodologiaAnalise(certificadoAnalise.Id, x))
                .ToList(), cancellationToken);
            await _uow.CompleteAsync(cancellationToken);

            await _uow.CommitAsync(cancellationToken);

            request.SetCertificadoAnaliseUId(certificadoAnalise.UId);
            request.SetNumero(certificadoAnalise.Numero);

            return true;
        }
    }
}