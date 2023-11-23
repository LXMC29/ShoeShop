using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShoeShop.Application.DTOs.Shoe;
using ShoeShop.Application.Features.Shoe.Requests.Queries;
using ShoeShop.Application.Repositories;

namespace ShoeShop.Application.Features.Shoe.Handlers.Queries
{
    public class GetProductListHendler : IRequestHandler<GetProductListRequest, List<ShoeDto>>
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IMapper _mapper;

        public GetProductListHendler(IShoeRepository shoeRepository, IMapper mapper)
        {
            _shoeRepository = shoeRepository;
            _mapper = mapper;
        }
        public async Task<List<ShoeDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
        {
            var lstShoe = await _shoeRepository.GetAllAsync();
            return _mapper.Map<List<ShoeDto>>(lstShoe);
        }
    }
}
