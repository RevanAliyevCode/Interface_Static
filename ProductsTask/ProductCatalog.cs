using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProductsTask
{
    public class ProductCatalog
    {
        public Product[] products = [];

        public Product[] Products { get => products; }

        public void AddToCatalog(params Product[] forAddProducts)
        {
            foreach (Product product in forAddProducts)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
        }

        public void GetAll()
        {
            foreach (Product product in products) product.GetDetails();
        }

        public void GetAllProductsByType(Type type)
        {
            foreach (Product product in products)
            {
                if (product.Type == type) product.GetDetails();
            }
        }
    }
}
