using DigiDigo.Domain.ItemAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDigo.Infrastrure.EFCore.Mapping.Items
{
    public class ItemsMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(x => x.ItemId);

            builder.Property(x => x.Quntity).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Color).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Size).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Size).HasMaxLength(60);

            //Mapping Relation 
            builder.HasMany(x => x.Product).WithOne(x => x.Item)
                .HasForeignKey(z=>z.ItemId);


        }
    }
}
