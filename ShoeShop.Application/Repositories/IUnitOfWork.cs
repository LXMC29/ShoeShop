using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Application.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IShoeRepository ShoeRepository { get; }
        IShoeDetailsRepository ShoeDetailsRepository { get; }
        IBrandRepositoty BrandRepositoty { get; }
        ICategoryRepository CategoryRepository { get; }
        IColorRepository ColorRepository { get; }
        IImageProductsRepository ImageProductsRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderDetailsRepository OrderDetailsRepository { get; }
        IPromotionRepository PromotionRepository { get; }
        ISizeRepository SizeRepository { get; }

        Task Save();
    }
}
