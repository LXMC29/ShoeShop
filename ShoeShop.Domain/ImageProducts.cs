using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class ImageProducts : BaseDomainEnntity
    {
        public Guid ProductDetailId { get; set; }
        public string ImageUrl { get; set; }
        public ShoeStatus ImageStatus { get; set; }

        public virtual ShoeDetails ShoeDetails { get; set; }
    }
}
