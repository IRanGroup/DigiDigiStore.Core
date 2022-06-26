using DigiDigo.Domain.ProductRoleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DigiDigo.Infrastrure.EFCore.Mapping.ProductRoles
{
    public class ProductRolesMapping : IEntityTypeConfiguration<ProductRole>
    {
        public void Configure(EntityTypeBuilder<ProductRole> builder)
        {
            builder.ToTable("ProductRoles");
            builder.HasKey(x => new { x.ProductId, x.RoleId });

            //Mapping Relation Product
            builder.HasOne(x => x.Product).WithMany(x => x.ProductRole)
                .HasForeignKey(z=>z.ProductId);

            //Mapping Relation Role
            builder.HasOne(x => x.Role).WithMany(x => x.ProductRole)
                .HasForeignKey(z => z.RoleId);
        }
    }
}
