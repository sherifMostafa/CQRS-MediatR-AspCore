using CqrsMediatR.Commands;
using CqrsMediatR.Domain;
using CqrsMediatR.FakeDataStore;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeData _fackData;
        public GetProductByIdHandler(FakeData fackData) => _fackData = fackData;
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) => await _fackData.GetProductById(request.id);
    }
}
