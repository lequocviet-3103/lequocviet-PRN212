using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {

        public Product GetProductById(int productId);
        public List<Product> GetAllProducts();
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);

        public void DeleteProduct(Product product);
        public List<Category> GetCategories();
        public List<Product> GetProductsByName(string productName);
    }
}
