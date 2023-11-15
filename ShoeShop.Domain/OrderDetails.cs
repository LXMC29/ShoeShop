using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;

namespace ShoeShop.Domain
{
    public class OrderDetails : BaseDomainEnntity
    {
        public Guid ShoeDetailsId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual ShoeDetails ShoeDetails { get; set; }
        public virtual Order Order { get; set; }
    }
}
