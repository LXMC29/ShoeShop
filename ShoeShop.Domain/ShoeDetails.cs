using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;

namespace ShoeShop.Domain
{
    public class ShoeDetails : BaseDomainEnntity
    {
        public Guid ShoeId { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual Shoe Shoe { get; set; }
        public virtual Size Size { get; set; }
        public virtual Color Color { get; set; }

        public virtual IEnumerable<ImageProducts> ImageProducts { get; set; }
        public virtual IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
