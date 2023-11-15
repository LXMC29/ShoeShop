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
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(x => x.Id);

            // quan hệ với ShoeDetails
            builder.HasOne<ShoeDetails>(c => c.ShoeDetails)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(c => c.ShoeDetailsId);

            // quan hệ với order
            builder.HasOne<Order>(c => c.Order)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(c => c.OrderId);

            builder.Property(c => c.Price).HasColumnType("decimal(18,2)");
        }
    }
}
