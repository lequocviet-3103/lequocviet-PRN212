using BusinessObjects_EF;
using DataAccessLayer_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_EF
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> GetProductsByCategory(int cate)
        {
            return productDAO.GetProductsByCategory(cate);
        }

        public List<Product> GetProsucts()
        {
            return productDAO.GetProsucts();
        }
    }
}
