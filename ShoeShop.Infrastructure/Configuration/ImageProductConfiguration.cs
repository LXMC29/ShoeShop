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
    public class ImageProductConfiguration : IEntityTypeConfiguration<ImageProducts>
    {
        public void Configure(EntityTypeBuilder<ImageProducts> builder)
        {
            builder.ToTable("ImageProducts");

            builder.HasKey(c => c.Id);

            // quan hệ với ShoeDetails
            builder.HasOne<ShoeDetails>(c => c.ShoeDetails)
                .WithMany(c => c.ImageProducts)
                .HasForeignKey(c => c.ProductDetailId);

            builder.Property(c => c.ImageUrl).IsRequired();
        }
    }
}
