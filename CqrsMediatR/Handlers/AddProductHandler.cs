using CqrsMediatR.Commands;
using CqrsMediatR.Domain;
using CqrsMediatR.FakeDataStore;
using MediatR;

namespace CqrsMediatR.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand , Product> 
    {
        private readonly FakeData _fakeData;

        public AddProductHandler(FakeData fakeData) => _fakeData = fakeData;

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeData.AddProduct(request.product);
            return request.product;
        }
    }
}
