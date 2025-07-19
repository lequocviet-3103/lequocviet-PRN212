using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public Product GetProductById(int productId)
        {
            using var context = new LucySalesDataContext();
            return context.Products
                .FirstOrDefault(p => p.ProductId == productId);
        }
        public List<Product> GetAllProducts()
        {
            using var context = new LucySalesDataContext();
            return context.Products.Include("Category").ToList();
        }
        public void AddProduct(Product product)
        {
            using var context = new LucySalesDataContext();
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            using var context = new LucySalesDataContext();
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            using var context = new LucySalesDataContext();
            var pro = context.Products.Include(o => o.OrderDetails).FirstOrDefault(p => p.ProductId == product.ProductId);
            if(pro != null)
            {
                context.OrderDetails.RemoveRange(pro.OrderDetails);
                context.Products.Remove(pro);
                context.SaveChanges();
            }
            

        }

        public List<Category> GetCategories()
        {
            using var context = new LucySalesDataContext();
            return context.Categories.ToList();
        }
        public List<Product> GetProductsByName(string productName)
        {
            using var context = new LucySalesDataContext();
            return context.Products
                .Where(p => p.ProductName.Contains(productName))
                .ToList();
        }
    }
}
