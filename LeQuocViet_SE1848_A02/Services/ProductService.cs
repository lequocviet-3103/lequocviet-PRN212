using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository(); 
        }
        public Product GetProductById(int productId)
        {
            return productRepository.GetProductById(productId);
        }
        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }
        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            productRepository.DeleteProduct(product);
        }

        public List<Category> GetCategories()
        {
            return productRepository.GetCategories();
        }
        public List<Product> GetProductsByName(string productName)
        {
            return productRepository.GetProductsByName(productName);
        }
    }
}
