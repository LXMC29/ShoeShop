using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Shoe : BaseDomainEnntity
    {
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public string NameShoe { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string DefaultImage { get; set; }
        public ShoeStatus ShoeStatus { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }

        public virtual IEnumerable<ShoeDetails> ShoeDetails { get; set; }
    }
}
