using WebAPIProject.Models;

namespace WebAPIProject.Services
{
    public class ProductService
    {

        private List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000
            },

            new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 20000
            }
        };


        public List<Product> GetProducts()
        {
            return products;
        }


        public Product GetProductById(int id)
        {
            return products.Find(x => x.Id == id);
        }


        public void AddProduct(Product product)
        {
            products.Add(product);
        }


        public void DeleteProduct(int id)
        {
            Product product = GetProductById(id);

            if(product != null)
            {
                products.Remove(product);
            }
        }

    }
}