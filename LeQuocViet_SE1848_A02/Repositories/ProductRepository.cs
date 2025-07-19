using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO productDAO = new ProductDAO();
        public Product GetProductById(int productId)
        {
            return productDAO.GetProductById(productId);
        }
        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }
        public void AddProduct(Product product)
        {
            productDAO.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            productDAO.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            productDAO.DeleteProduct(product);
        }

        public List<Category> GetCategories()
        {
            return productDAO.GetCategories();
        }
        public List<Product> GetProductsByName(string productName)
        {
            return productDAO.GetProductsByName(productName);
        }
    }
}
