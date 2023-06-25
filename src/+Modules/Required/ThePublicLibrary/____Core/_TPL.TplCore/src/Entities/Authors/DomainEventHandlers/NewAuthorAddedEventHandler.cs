namespace TPL.TplCore.Entities;
public class NewAuthorAddedEventHandler : INotificationHandler<NewAuthorAddedEvent>
    {
        public async Task Handle(NewAuthorAddedEvent domainEvent, CancellationToken cancellationToken)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // do awesome things            
        }
    }