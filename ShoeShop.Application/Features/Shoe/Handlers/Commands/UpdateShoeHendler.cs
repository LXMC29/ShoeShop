using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShoeShop.Application.DTOs.Common;
using ShoeShop.Application.Exceptions;
using ShoeShop.Application.Features.Shoe.Requests.Commands;
using ShoeShop.Application.Repositories;

namespace ShoeShop.Application.Features.Shoe.Handlers.Commands
{
    public class UpdateShoeHendler : IRequestHandler<UpdateShoeRequest>
    {
        private readonly IMapper _mapper;
        private readonly IShoeRepository _shoeRepository;

        public UpdateShoeHendler(IMapper mapper, IShoeRepository shoeRepository)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
        }
        public async Task Handle(UpdateShoeRequest request, CancellationToken cancellationToken)
        {
            var product = await _shoeRepository.GetByIdAsync(request.Id);
            if (product == null)
                throw new NotFoundException(nameof(product), request.Id);

            _mapper.Map(request.UpdateShoe, product);

            await _shoeRepository.UpdateAsync(product);
        }
    }
}
