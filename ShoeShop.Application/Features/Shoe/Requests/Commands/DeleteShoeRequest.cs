using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ShoeShop.Application.Features.Shoe.Requests.Commands
{
    public class DeleteShoeRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
