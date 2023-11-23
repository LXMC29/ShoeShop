using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoeShop.Domain;
using ShoeShop.Domain.Enums;

namespace ShoeShop.Infrastructure.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NameBrand).IsRequired();

            builder.HasData(
                new Brand
                {
                    Id = new Guid("2199D691-F475-425F-B2A4-E8E3B50E8A8A"),
                    NameBrand = "Nike",
                    BrandStatus = ShoeStatus.Active,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "ChienCo"
                }
            );
        }
    }
}
