using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain.Common;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Domain
{
    public class Color : BaseDomainEnntity
    {
        public string NameColor { get; set; }
        public ShoeStatus ColorStatus { get; set; }

        public virtual IEnumerable<ShoeDetails> ShoeDetails { get; set; }
    }
}
