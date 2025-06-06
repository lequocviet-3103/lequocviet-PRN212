using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public static List<Product> listProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
            //Product chef = new Product(4, "chef Anton's Cajun Seasoning", 2, 34, 22);
            //Product chefMix = new Product(5, "Chef Anton's Gumbo Mix", 2, 45, 34);
            //Product grandma = new Product(6, "Grandma's Boysenberry Spread", 2, 21, 25);
            //Product uncle = new Product(, "Uncle Bob's Organic Dried Pears", 7, 22, 30);
            //Product northwoods = new Product(8, "Northwoods Cranberry Sauce", 2, 10, 40);
            //Product mishi = new Product(9, "Mishi Kobe Niku", 6, 12, 97);
            //Product ikura = new Product(10, "Ikura", 8, 13, 32);
            //listProducts = new List<Product> { chai, chang, aniseed, che, chefMix, grandma };
        }

        public List<Product> GetProducts()
        {

            return listProducts;
        }

        public static List<Product> GetProducts1()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreDataContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e) { }

            return listProducts;
        }

        public void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == product.ProductID)
                {
                    p.ProductID = product.ProductID;
                    p.ProductName = product.ProductName;
                    p.ProductID = product.ProductID;
                    p.UnitsInStock = product.UnitsInStock;
                    p.ProductID = product.ProductID;
                }

            }
        }
        public void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == product.ProductID)
                {
                    listProducts.Remove(p);
                }
            }
        }

        public Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
