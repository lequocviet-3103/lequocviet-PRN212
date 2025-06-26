using BusinessObject;
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
        ProductDAO productDAO = new ProductDAO();

        public bool DeleteProduct(int id)
        {
            return productDAO.DeleteProduct(id);
        }

        public bool DeleteProduct(Product product)
        {
            return productDAO.DeleteProduct(product);
        }

        public void GenerateSampleDataSet()
        {
            productDAO.GenerateSampleDataSet();
        }

        public Product GetProduct(int id)
        {
            return productDAO.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();

        }

        public bool SaveProduct(Product product)
        {
            productDAO.SaveProduct(product);
            return true; // Assuming the save operation is always successful for simplicity
        }

        public bool UpdateProduct(Product product)
        {
            return productDAO.UpdateProduct(product);
        }
    }
}
