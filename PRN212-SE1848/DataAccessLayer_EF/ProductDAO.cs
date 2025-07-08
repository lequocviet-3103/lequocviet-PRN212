using BusinessObjects_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_EF
{
    public class ProductDAO
    {
        public MyStoreContext context = new MyStoreContext();
        public List<Product> GetProsucts()
        {
            return context.Products.ToList();
        }
        public List<Product> GetProductsByCategory(int cate)
        {
            return context.Products.Where(p => p.CategoryId == cate).ToList();
        }
    }
}
