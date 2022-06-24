using DigiDigo.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDigo.Infrastrure.EFCore.Mapping.Products
{
    public class ProductsMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductId);

            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ImageName).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();

        }
    }
}
