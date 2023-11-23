using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.Repositories;
using ShoeShop.Domain;

namespace ShoeShop.Infrastructure.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepositoty
    {
        private readonly ShoeShopDbContext _context;

        public BrandRepository(ShoeShopDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
