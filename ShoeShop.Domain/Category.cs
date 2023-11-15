using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Category : BaseDomainEnntity
    {
        public string NameCategory { get; set; }
        public ShoeStatus CategoryStatus { get; set; }

        public virtual IEnumerable<Shoe> Shoes { get; set; }
    }
}
