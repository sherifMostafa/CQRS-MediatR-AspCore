using CqrsMediatR.FakeDataStore;
using CqrsMediatR.Notifications;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class CashInvalidationHandler : INotificationHandler<ProductAddedNotification>
    {

        private readonly FakeData _fakeData;

        public CashInvalidationHandler(FakeData fakeData) => _fakeData = fakeData;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeData.EventOccured(notification.product, "Cash Invalidated");
            await Task.CompletedTask;
        }
    }
}
