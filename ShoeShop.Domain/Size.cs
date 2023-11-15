using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Size : BaseDomainEnntity
    {
        public string NameSize { get; set; }
        public ShoeStatus SizeStatus { get; set; }

        public virtual IEnumerable<ShoeDetails> ShoeDetails { get; set; }
    }
}
