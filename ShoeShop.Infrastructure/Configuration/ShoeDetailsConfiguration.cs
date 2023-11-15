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
    public class ShoeDetailsConfiguration : IEntityTypeConfiguration<ShoeDetails>
    {
        public void Configure(EntityTypeBuilder<ShoeDetails> builder)
        {
            builder.ToTable("ShoeDetails");

            builder.HasKey(x => x.Id);

            // quan hệ với shoe
            builder.HasOne<Shoe>(c => c.Shoe)
                .WithMany(p => p.ShoeDetails)
                .HasForeignKey(c => c.ShoeId);

            // quan hệ với size
            builder.HasOne<Size>(c => c.Size)
                .WithMany(c => c.ShoeDetails)
                .HasForeignKey(c => c.SizeId);

            // quan hệ với color
            builder.HasOne<Color>(c => c.Color)
                .WithMany(c => c.ShoeDetails)
                .HasForeignKey(c => c.ColorId);
        }
    }
}
