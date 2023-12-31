﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShoeShop.Application.DTOs.Common;
using ShoeShop.Application.DTOs.Shoe;
using ShoeShop.Application.Features.Shoe.Requests.Commands;
using ShoeShop.Application.Repositories;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Application.Features.Shoe.Handlers.Commands
{
    public class CreateShoeHendler : IRequestHandler<CreateShoeRequest, BaseDto>
    {
        private readonly IMapper _mapper;
        private readonly IShoeRepository _shoeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateShoeHendler(IMapper mapper, IShoeRepository shoeRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _shoeRepository = shoeRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<BaseDto> Handle(CreateShoeRequest request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Domain.Shoe>(request.CreateShoe);
            product.Id = Guid.NewGuid();
            product.CreatedAt = DateTime.Now;
            product.ShoeStatus = ShoeStatus.Active;

            await _unitOfWork.ShoeRepository.AddAsync(product);
            await _unitOfWork.Save();

            request.CreateShoe.Id = product.Id;

            var shoeNew = await _shoeRepository.GetByIdAsync(request.CreateShoe.Id);
            return _mapper.Map<ShoeDto>(shoeNew);
        }
    }
}
