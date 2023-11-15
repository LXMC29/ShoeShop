using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoeShop.Infrastructure.Identity.Model;

namespace ShoeShop.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection InfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoeShopDbContext>(otp =>
                otp.UseSqlServer(configuration.GetConnectionString("ShoeShop")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ShoeShopDbContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
