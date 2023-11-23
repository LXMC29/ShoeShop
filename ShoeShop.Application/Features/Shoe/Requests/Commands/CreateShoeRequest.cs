using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShoeShop.Application.DTOs.Common;
using ShoeShop.Application.DTOs.Shoe;

namespace ShoeShop.Application.Features.Shoe.Requests.Commands
{
    public class CreateShoeRequest : IRequest<BaseDto>
    {
        public CreateShoeDto CreateShoe { get; set; }
    }
}
