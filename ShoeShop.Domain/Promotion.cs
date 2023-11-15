using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Promotion : BaseDomainEnntity
    {
        public string Code { get; set; }
        public int DiscountPrcent { get; set; }
        public PromotionStatus PromotionStatus { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
