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
        private readonly IUnitOfWork _unitOfWork;

        public DeleteShoeHendler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(DeleteShoeRequest request, CancellationToken cancellationToken)
        {
            var shoe = await _unitOfWork.ShoeRepository.GetByIdAsync(request.Id);
            await _unitOfWork.ShoeRepository.DeleteAsync(shoe);
            await _unitOfWork.Save();
        }
    }
}
