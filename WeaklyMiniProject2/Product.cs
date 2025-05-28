using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklyMiniProject2
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Product(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name:{Name}".PadRight(20) + $"Category: {Category}".PadRight(20) + $"Price: {Price}";
        }


    }
}
