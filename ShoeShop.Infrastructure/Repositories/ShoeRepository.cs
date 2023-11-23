﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.Repositories;
using ShoeShop.Domain;

namespace ShoeShop.Infrastructure.Repositories
{
    public class ShoeRepository : GenericRepository<Shoe>, IShoeRepository
    {
        private readonly ShoeShopDbContext _context;
        public ShoeRepository(ShoeShopDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
