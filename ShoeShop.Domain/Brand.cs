using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Brand : BaseDomainEnntity
    {
        public string NameBrand { get; set; }
        public ShoeStatus BrandStatus { get; set; }

        public virtual IEnumerable<Shoe> Shoes { get; set; }
    }
}
