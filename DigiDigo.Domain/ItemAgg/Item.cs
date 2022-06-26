using DigiDigo.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiDigo.Domain.ItemAgg
{
    public class Item
    {
        public int ItemId { get; set; }
        public int Quntity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }


        //Relation To Product
        public IEnumerable<Product> Product { get; set; }
        //END Relation To Product


        public Item(int quntity, decimal price, string color, string size, string description)
        {
            Quntity = quntity;
            Price = price;
            Color = color;
            Size = size;
            Description = description;
            CreationDate = DateTime.Now;
            Product = new List<Product>();
        }

        public void Edit(int quntity, decimal price, string color, string size, string description)
        {
            Quntity = quntity;
            Price = price;
            Color = color;
            Size = size;
            Description = description;
        }

    }
}
