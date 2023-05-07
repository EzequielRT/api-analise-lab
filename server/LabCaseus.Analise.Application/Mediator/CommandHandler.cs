using LabCaseus.Analise.Application.Mediator.Notifications;
using MediatR;

namespace LabCaseus.Analise.Application.Mediator
{
    public abstract class CommandHandler
    {
        protected readonly IMediatorHandler _mediator;
        protected readonly DomainNotificationHandler _notifications;

        protected CommandHandler(IMediatorHandler mediator, INotificationHandler<DomainNotification> notifications)
        {
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)notifications;
        }
    }
}