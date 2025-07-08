using BusinessObjects_EF;
using Repositories_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services_EF
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository();
        }
        public List<Product> GetProductsByCategory(int cate)
        {
            return productRepository.GetProductsByCategory(cate);
        }

        public List<Product> GetProsucts()
        {
            return productRepository.GetProsucts();
        }
    }
}
