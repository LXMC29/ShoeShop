using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.Repositories;
using ShoeShop.Domain;

namespace ShoeShop.Infrastructure.Repositories
{
    public class PromotionRepository : GenericRepository<Promotion>, IPromotionRepository
    {
        private readonly ShoeShopDbContext _context;

        public PromotionRepository(ShoeShopDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
