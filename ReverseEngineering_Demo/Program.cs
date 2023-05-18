using ReverseEngineering_Demo.Models;

namespace ReverseEngineering_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductLayer productLayer = new ProductLayer();
            //Adding
            Product p = new Product { Name = "Refrigirator", Price = 85000, Qty = 5};
            //productLayer.AddProduct(p);
            //Deleting
            productLayer.DeleteProduct(5003);
            productLayer.DeleteProduct(5004);
            //Updating
            p = new Product { Id = 4 ,Name = "Benq Projector", Price = 85000, Qty = 5 };
            productLayer.Update(4, p);
            List<Product> list = productLayer.GetAll();
            foreach (Product product in list)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}, {product.Qty}");
            }
        }
    }
}