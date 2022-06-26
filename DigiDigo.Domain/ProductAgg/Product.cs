using DigiDigo.Domain.ItemAgg;
using DigiDigo.Domain.ProductRoleAgg;
using System;
using System.Collections.Generic;

namespace DigiDigo.Domain.ProductAgg
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string Title { get; private set; }
        public string ImageName { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool IsExisting { get; private set; }
        public bool IsDeleted { get; private set; }

        // Relation To Item
        public int ItemId { get; set; }
        public Item Item { get; set; }

        //Relation To ProductRole
        public List<ProductRole> ProductRole { get; set; }


        public Product(string title, string description)
        {
            Title = title;
            Description = description;
            CreationDate = DateTime.Now;
            IsExisting = true;
            IsDeleted = false;
        }

        public void Edit(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public void Removed()
        {
            IsDeleted = true;
        }



    }
}
