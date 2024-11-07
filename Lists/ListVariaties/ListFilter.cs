using Lists.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ListVariaties
{
    internal class ListFilter
    {
        public ListFilter()
        {
            ListFilterMethod();
        }

        private void ListFilterMethod()
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Apple", Price = 0.80},
                new Product {Name = "Banana", Price = 0.30},
                new Product {Name = "Cherry", Price = 3.80},
            };

            // add items to the list
            products.Add(new Product { Name = "Berries", Price = 2.99 });

            // The code filters the products list to find all products
            // that have a price lower than 1.0
            // and stores those products in the cheapProducts list.
            // Give me the products where this condition is met

            // LINQ is used here for querying and filtering the products list.
            List<Product> cheapProducs = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Available Products for less than $1:");

            foreach (Product product in cheapProducs)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price} $");
            }

            //Console.WriteLine("Available Products:");

            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"Product name: {product.Name} for {product.Price} $");
            //}

            //Console.WriteLine("Hello from ListFilter Class!");
        }
    }
}
