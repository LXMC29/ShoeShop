using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ShoeShop.Application.Repositories;
using ShoeShop.Application.Repositories.Generic;
using ShoeShop.Application.Repositories.Identity;
using ShoeShop.Infrastructure.Identity.Model;
using ShoeShop.Infrastructure.Repositories;
using ShoeShop.Infrastructure.Repositories.Identity;

namespace ShoeShop.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection InfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoeShopDbContext>(otp =>
                otp.UseSqlServer(configuration.GetConnectionString("ShoeShop")));

            // add Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ShoeShopDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IShoeRepository, ShoeRepository>();
            services.AddScoped<IShoeDetailsRepository, ShoeDetailsRepository>();
            services.AddScoped<IBrandRepositoty, BrandRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IImageProductsRepository, ImageProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailRepository>();
            services.AddScoped<IPromotionRepository, PromotionRepository>();
            services.AddScoped<ISizeRepository, SizeRepository>();

            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
