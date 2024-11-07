using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lists.Products;

namespace Lists.ListVariaties
{
    internal class ListComplexObject
    {
        public ListComplexObject()
        {
            ListComplexObjectMethod();
        }

        private void ListComplexObjectMethod()
        {

            List<Product> products = new List<Product>
            {
                new Product {Name = "Apple", Price = 0.80},
                new Product {Name = "Banana", Price = 0.30},
                new Product {Name = "Cherry", Price = 3.80},
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine("Available Products:");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price} $");
            }

            //Console.WriteLine("Hello from ListComplexObject Class!");

        }
    }
}
