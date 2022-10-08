using CqrsMediatR.Domain;
using CqrsMediatR.FakeDataStore;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {

        private readonly FakeData _fakeData;

        public GetProductsHandler(FakeData fakeData) => _fakeData = fakeData;
       
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
            => await _fakeData.GetAllProducts();
    }
}
