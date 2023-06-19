namespace TPL.Core.Entities;
public class MemberBirthdayDomainEventHandler : INotificationHandler<MemberBirthdayDomainEvent>
    {
        public async Task Handle(MemberBirthdayDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // do awesome things            
        }
    }