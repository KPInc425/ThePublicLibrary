namespace YMI.YmiCore.Entities;
public class NewActorAddedEventHandler : INotificationHandler<NewActorAddedEvent>
    {
        public async Task Handle(NewActorAddedEvent domainEvent, CancellationToken cancellationToken)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));
            await Task.Yield();
            // do awesome things            
        }
    }