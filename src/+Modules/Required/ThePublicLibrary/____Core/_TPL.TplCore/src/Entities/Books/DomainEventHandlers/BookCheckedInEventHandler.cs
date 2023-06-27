namespace TPL.TplCore.Entities;
public class BookCheckedInDomainEventHandler : INotificationHandler<BookCheckedInDomainEvent>
    {
        public async Task Handle(BookCheckedInDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));
            await Task.Yield();
            // do awesome things            
        }
    }