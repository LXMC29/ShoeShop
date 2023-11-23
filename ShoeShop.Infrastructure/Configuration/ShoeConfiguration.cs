using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoeShop.Domain;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Infrastructure.Configuration
{
    public class ShoeConfiguration : IEntityTypeConfiguration<Shoe>
    {
        public void Configure(EntityTypeBuilder<Shoe> builder)
        {
            builder.ToTable("Shoes");

            builder.HasKey(c => c.Id);

            // quan hệ với brand
            builder.HasOne<Brand>(c => c.Brand)
                .WithMany(c => c.Shoes)
                .HasForeignKey(c => c.BrandId);

            // quan hệ với category
            builder.HasOne<Category>(c => c.Category)
                .WithMany(c => c.Shoes)
                .HasForeignKey(c => c.CategoryId);

            builder.Property(c => c.NameShoe).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Price).HasColumnType("decimal(18,2)");

            // seeding data
            builder.HasData(
                    new Shoe
                    {
                        Id = new Guid("0E6BF7F0-1A58-4382-92E8-71AC890E441B"),
                        NameShoe = "CoShoe123",
                        Price = 1999999,
                        Description = "Giay xin, chay ngay di",
                        ShoeStatus = ShoeStatus.Active,
                        CreatedAt = DateTime.Now,
                        CreatedBy = "ChienCo"
                    }
                );
        }
    }
}
