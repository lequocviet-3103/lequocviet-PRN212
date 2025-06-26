using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void GenerateSampleDataSet()
        {
            products.Add(new Product { Id = 1, Name = "Coca", Quantity = 10, Price = 100.0 });
            products.Add(new Product { Id = 2, Name = "Pepsi", Quantity = 20, Price = 200.0 });
            products.Add(new Product { Id = 3, Name = "Tiger", Quantity = 30, Price = 300.0 });
            products.Add(new Product { Id = 4, Name = "Sting", Quantity = 20, Price = 200.0 });
            products.Add(new Product { Id = 5, Name = "Redbull", Quantity = 30, Price = 300.0 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
            {
                return false; // Product with the same ID already exists
            }
            products.Add(product);
            return true; // Product added successfully
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public bool UpdateProduct(Product product)
        {
            //tìm xem product muốn sửa này có tồn tại không?
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
            {
                return false; // không tìm thấy

            }
            old.Name = product.Name;
            old.Quantity = product.Quantity;
            old.Price = product.Price;
            return true; // cập nhật thành công

        }
        public bool DeleteProduct(int id)
        {
            Product p = GetProduct(id);
            if(p!=null)
            {
                products.Remove(p);
                return true;
            }

            return false;
        }
        public bool DeleteProduct(Product product)
        {
            if (product == null) return false;

            return DeleteProduct(product.Id);
        }
    }
}
