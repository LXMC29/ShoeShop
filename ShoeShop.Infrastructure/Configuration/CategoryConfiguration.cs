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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(c => c.NameCategory).IsRequired();

            builder.HasData(
                new Category
                {
                    Id = new Guid("8E017451-AE52-470C-A666-90F871C47947"),
                    NameCategory = "The thao",
                    CategoryStatus = ShoeStatus.Active,
                    CreatedBy = "ChienCo",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
