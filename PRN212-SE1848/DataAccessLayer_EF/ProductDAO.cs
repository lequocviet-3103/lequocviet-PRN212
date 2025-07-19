﻿using BusinessObjects_EF;
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

        public bool SaveProduct(Product product)
        {
            if (product == null) return false;
            Product p_existing = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if(p_existing != null) return false;
            context.Products.Add(product);
            int ret = context.SaveChanges();
            return ret > 0;
        }
        public bool UpdateProduct(Product product)
        {
            if (product == null) return false;
            Product p_existing = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (p_existing == null) return false;
            p_existing.ProductName = product.ProductName;
            p_existing.UnitPrice = product.UnitPrice;
            p_existing.UnitsInStock = product.UnitsInStock;
            p_existing.CategoryId = product.CategoryId;
            int ret = context.SaveChanges();
            return ret > 0;
        }

        public bool DeleteProduct(int productId) {
            Product p_existing = context.Products.FirstOrDefault(p => p.ProductId == productId);
            if(p_existing != null)
            {
                context.Products.Remove(p_existing);
                int ret = context.SaveChanges();
                return ret > 0;
            }
            return false;
        }

    }
}
