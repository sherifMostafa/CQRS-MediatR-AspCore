using CqrsMediatR.FakeDataStore;
using CqrsMediatR.Notifications;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {

        private readonly FakeData _fakeData;

        public EmailHandler(FakeData fakeData) => _fakeData = fakeData;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeData.EventOccured(notification.product, "Email Sent");
            await Task.CompletedTask;
        }
    }
}
