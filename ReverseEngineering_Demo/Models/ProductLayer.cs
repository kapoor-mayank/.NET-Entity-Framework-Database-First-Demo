using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineering_Demo.Models
{
    internal class ProductLayer
    {
        readonly ProductContext context = new ProductContext();

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product p = context.Find<Product>(id);
            Console.WriteLine($"{p.Id}");
            context.Products.Remove(p);
            context.SaveChanges();
        }
        public void Update(int id, Product product)
        {
            ProductContext context = new ProductContext();
            if(product != null && id == product.Id)
            {
                context.Update(product);
                context.SaveChanges();
            }

        }
    }
}
