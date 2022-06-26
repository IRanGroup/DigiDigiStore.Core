using DigiDigo.Domain.ItemAgg;
using DigiDigo.Domain.ProductAgg;
using DigiDigo.Domain.ProductRoleAgg;
using DigiDigo.Domain.RoleAgg;
using DigiDigo.Infrastrure.EFCore.Mapping.Products;
using Microsoft.EntityFrameworkCore;

namespace DigiDigo.Infrastrure.EFCore
{
    public class DigiDigoContext : DbContext
    {
        public DigiDigoContext(DbContextOptions<DigiDigoContext> options):base(options)
        {

        }

        #region Database Entities 
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ProductRole> ProductRoles { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductsMapping).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
