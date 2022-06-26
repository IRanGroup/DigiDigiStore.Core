using DigiDigo.Domain.RoleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiDigo.Infrastrure.EFCore.Mapping.Roles
{
    public class RolesMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(x => x.RoleId);

            builder.Property(x => x.RoleTitle).HasMaxLength(255).IsRequired();
            builder.Property(x => x.RoleDescription).HasMaxLength(500).IsRequired();
           

        }
    }
}
