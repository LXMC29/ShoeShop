using ShoeShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShoeShopDbContext _context;

        public UnitOfWork(ShoeShopDbContext context)
        {
            _context = context;
            ShoeRepository = new ShoeRepository(_context);
            ShoeDetailsRepository = new ShoeDetailsRepository(_context);
            BrandRepositoty = new BrandRepository(_context);
            CategoryRepository = new CategoryRepository(_context);
            ColorRepository = new ColorRepository(_context);
            ImageProductsRepository = new ImageProductRepository(_context);
            OrderRepository = new OrderRepository(_context);
            OrderDetailsRepository = new OrderDetailRepository(_context);
            PromotionRepository = new PromotionRepository(_context);
            SizeRepository = new SizeRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IShoeRepository ShoeRepository { get; }
        public IShoeDetailsRepository ShoeDetailsRepository { get; }
        public IBrandRepositoty BrandRepositoty { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IColorRepository ColorRepository { get; }
        public IImageProductsRepository ImageProductsRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IOrderDetailsRepository OrderDetailsRepository { get; }
        public IPromotionRepository PromotionRepository { get; }
        public ISizeRepository SizeRepository { get; }
        public async Task Save()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
