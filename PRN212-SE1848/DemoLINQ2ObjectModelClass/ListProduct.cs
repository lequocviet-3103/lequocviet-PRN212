using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2ObjectModelClass
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product() { Id = 1, Name = "p1", Quantity=10, Price = 5});
            products.Add(new Product() { Id = 2, Name = "p2", Quantity = 11, Price = 2 });
            products.Add(new Product() { Id = 3, Name = "p3", Quantity = 2, Price = 202 });
            products.Add(new Product() { Id = 4, Name = "p4", Quantity = 13, Price = 201 });
            products.Add(new Product() { Id = 5, Name = "p5", Quantity = 14, Price = 240 });
            products.Add(new Product() { Id = 6, Name = "p6", Quantity = 142, Price = 620 });
            products.Add(new Product() { Id = 7, Name = "p7", Quantity = 101, Price = 920 });
            products.Add(new Product() { Id = 8, Name = "p8", Quantity = 103, Price = 210 });
            products.Add(new Product() { Id = 9, Name = "p9", Quantity = 1021, Price = 120 });
            products.Add(new Product() { Id = 10, Name = "p10", Quantity = 110, Price = 220 });
        }
        public List<Product> FillterProductsByPrice(double price1, double price2)
        {
            var result = from p in products where p.Price >=price1 && p.Price <=price2 select p;
            return result.ToList();
        }
        public List<Product> FillterProductsByPrice2(double price1, double price2) { 
            Product p = new Product();
            if(p.Price >=price1 && p.Price <= price2)
            {
               
            }
            return products.Where(x=>x.Price >=price1 && x.Price <=price2).ToList();
        }

        public List<Product> SortProductsByPriceAsc()
        {
            return products.OrderBy(p => p.Price).ToList();
        }

        public List<Product> SortProductsByPriceAsc2()
        {
            var result = from p in products orderby p.Price select p;
            return result.ToList();
        }

        public List<Product> SortProductsByPriceDesc()
        {
            return products.OrderByDescending(p => p.Price).ToList();
        }

        public List<Product> SortProductsByPriceDesc2()
        {
            var result = from p in products orderby p.Price descending select p;
            return result.ToList();
        }

        public double SomeOfValue()
        {
            return products.Sum(p=>p.Price * p.Quantity);
        }

        public Product SearchProductDetail(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetTopNProduct(int n)
        {
            return products.OrderByDescending(p => p.Price * p.Quantity).Take(n).ToList();
        }

        

    }
}
