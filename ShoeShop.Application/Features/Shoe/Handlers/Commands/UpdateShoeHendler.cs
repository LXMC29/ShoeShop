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
        private readonly IUnitOfWork _unitOfWork;

        public UpdateShoeHendler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(UpdateShoeRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.ShoeRepository.GetByIdAsync(request.Id);
            if (product == null)
                throw new NotFoundException(nameof(product), request.Id);

            _mapper.Map(request.UpdateShoe, product);

            await _unitOfWork.ShoeRepository.UpdateAsync(product);
            await _unitOfWork.Save();
        }
    }
}
