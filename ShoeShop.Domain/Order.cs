using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Order : BaseDomainEnntity
    {
        public Guid PromotionId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public string Note { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public virtual IEnumerable<OrderDetails> OrderDetails { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
