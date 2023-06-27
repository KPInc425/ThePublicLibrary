namespace YMI.YmiCore.Entities;
public class VideoCheckedInDomainEventHandler : INotificationHandler<VideoCheckedInDomainEvent>
    {
        public async Task Handle(VideoCheckedInDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // do awesome things            
        }
    }