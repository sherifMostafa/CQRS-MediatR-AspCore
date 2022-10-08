using CqrsMediatR.Domain;
using MediatR;

namespace CqrsMediatR.Commands
{
    public record AddProductCommand(Product product) :IRequest<Product>;
}
