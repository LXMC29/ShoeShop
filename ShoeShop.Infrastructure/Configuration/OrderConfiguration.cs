using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoeShop.Domain;

namespace ShoeShop.Infrastructure.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(c => c.Id);

            // quan hệ với khuyễn mãi
            builder.HasOne<Promotion>(c => c.Promotion)
                .WithMany(c => c.Orders)
                .HasForeignKey(c => c.PromotionId);

            builder.Property(c => c.CustomerName).HasMaxLength(100).IsRequired();
            builder.Property(c => c.PhoneNumber).IsRequired();
            builder.Property(c => c.Total).HasColumnType("decimal(18,2)");
        }
    }
}
