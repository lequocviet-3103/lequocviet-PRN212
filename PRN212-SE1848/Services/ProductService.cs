using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        IProductRepository iProductRepository;
        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }

        public bool DeleteProduct(int id)
        {
            return iProductRepository.DeleteProduct(id);
        }

        public bool DeleteProduct(Product product)
        {
            return iProductRepository.DeleteProduct(product);
        }

        public void GenerateSampleDataSet()
        {
            iProductRepository.GenerateSampleDataSet();
        }

        public Product GetProduct(int id)
        {
            return iProductRepository.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public bool SaveProduct(Product product)
        {
            iProductRepository.SaveProduct(product);
            return true; // Assuming the save operation is always successful for simplicity
        }

        public bool UpdateProduct(Product product)
        {
            return iProductRepository.UpdateProduct(product);
        }
    }
}