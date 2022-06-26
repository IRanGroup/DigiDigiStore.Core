using DigiDigo.Domain.ProductAgg;
using DigiDigo.Domain.RoleAgg;

namespace DigiDigo.Domain.ProductRoleAgg
{
    public class ProductRole
    {
        public int ProductId { get; set; }
        public int RoleId { get; set; }

        //Relation To Product And Role
        public Product Product { get; set; }
        public Role Role { get; set; }

    }
}
