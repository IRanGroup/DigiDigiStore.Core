using DigiDigo.Domain.ProductRoleAgg;
using System.Collections.Generic;

namespace DigiDigo.Domain.RoleAgg
{
    public class Role
    {

        public int RoleId { get; private set; }
        public string RoleTitle { get; private set; }
        public string RoleDescription { get; private set; }
        public bool DisableRole { get; private set; }

        //Relation To ProductRole
        public List<ProductRole> ProductRole { get; set; }


        public Role(string roleTitle, string roleDescription)
        {
            RoleTitle = roleTitle;
            RoleDescription = roleDescription;
            DisableRole = false;
        }

        public void Edit(string roleTitle, string roleDescription)
        {
            RoleTitle = roleTitle;
            RoleDescription = roleDescription;
        }

        public void Disable()
        {
            DisableRole = true;
        }


    }
}
