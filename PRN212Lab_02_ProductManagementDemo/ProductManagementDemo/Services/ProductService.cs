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
        private readonly IProductRepository iProductRepository;
        // Ensure the ProductRepository class is properly referenced and exists in the Repositories namespace  
        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }
        public void SaveProduct(Product p)
        {
            iProductRepository.SaveProduct(p);
        }
        public void DeleteProduct(Product p)
        {
            iProductRepository.DeleteProduct(p);
        }
        public void UpdateProduct(Product p)
        {
            iProductRepository.UpdateProduct(p);
        }
        public List<Product> GetProducts()
        {
            return iProductRepository.GetAllProducts();
        }
        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }
    }
}
