using CqrsMediatR.Domain;
using MediatR;

namespace CqrsMediatR.Notifications
{
    public record ProductAddedNotification(Product product) : INotification;
    
}
