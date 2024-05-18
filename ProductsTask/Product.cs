using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTask
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Type Type { get; set; }

        public Product(string name, decimal price, Type type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Type: {Type}");
        }
    }
}
