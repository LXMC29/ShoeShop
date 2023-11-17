using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.DTOs.Shoe;
using ShoeShop.Domain;

namespace ShoeShop.Application.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Shoe, ShoeDto>().ReverseMap();
        }
    }
}
