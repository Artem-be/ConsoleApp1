using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Store
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in Products)
            {

                decimal discountedPrice = product.Price * 0.90m; 
                Console.WriteLine(product.GetInformation() + $", Цена со скидкой: {discountedPrice:C}");

            }
        }
    }
}
