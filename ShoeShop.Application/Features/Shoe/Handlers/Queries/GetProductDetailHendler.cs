using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShoeShop.Application.DTOs.Shoe;
using ShoeShop.Application.Exceptions;
using ShoeShop.Application.Features.Shoe.Requests.Queries;
using ShoeShop.Application.Repositories;

namespace ShoeShop.Application.Features.Shoe.Handlers.Queries
{
    public class GetProductDetailHendler : IRequestHandler<GetProductDetailRequest, ShoeDto>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;

        public GetProductDetailHendler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _shoeRepository = shoeRepository;
            _mapper = mapper;
        }
        public async Task<ShoeDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
        {
            var shoe = await _shoeRepository.GetByIdAsync(request.Id);

            if (shoe == null)
                throw new NotFoundException(nameof(shoe), request.Id);

            return _mapper.Map<ShoeDto>(shoe);
        }
    }
}
