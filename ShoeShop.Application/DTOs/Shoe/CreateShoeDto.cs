using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.DTOs.Common;

namespace ShoeShop.Application.DTOs.Shoe
{
    public class CreateShoeDto : BaseDto
    {
        public Guid? BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public string NameShoe { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string? DefaultImage { get; set; }
    }
}
