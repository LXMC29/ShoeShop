using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.DTOs.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Application.DTOs.Shoe
{
    public class ShoeDto : BaseDto
    {
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public string NameShoe { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string DefaultImage { get; set; }
        public ShoeStatus ShoeStatus { get; set; }
    }
}
