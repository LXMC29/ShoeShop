using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShoeShop.Application.Features.Shoe.Requests.Commands;
using ShoeShop.Application.Repositories;

namespace ShoeShop.Application.Features.Shoe.Handlers.Commands
{
    public class DeleteShoeHendler : IRequestHandler<DeleteShoeRequest>
    {
        private readonly IShoeRepository _shoeRepository;

        public DeleteShoeHendler(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }
        public async Task Handle(DeleteShoeRequest request, CancellationToken cancellationToken)
        {
            var shoe = await _shoeRepository.GetByIdAsync(request.Id);
            await _shoeRepository.DeleteAsync(shoe);
        }
    }
}
