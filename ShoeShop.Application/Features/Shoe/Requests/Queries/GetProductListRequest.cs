using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShoeShop.Application.DTOs.Shoe;

namespace ShoeShop.Application.Features.Shoe.Requests.Queries
{
    public class GetProductListRequest : IRequest<List<ShoeDto>>
    {
    }
}
