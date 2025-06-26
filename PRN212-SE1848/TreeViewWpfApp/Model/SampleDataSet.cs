using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWpfApp.Model
{
    public class SampleDataSet
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
             Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category { Id = 1, Name = "Nước ngọt" };
            Category c2 = new Category { Id = 2, Name = "Bia - Rượu" };
            Category c3 = new Category { Id = 3, Name = "Thức ăn nhanh" };
            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);
            Product p1 = new Product { Id = 1, Name = "Pepsi", Quantity = 100, Price = 10.5 };
            Product p2 = new Product { Id = 2, Name = "Coca Cola", Quantity = 200, Price = 12.0 };
            Product p3 = new Product { Id = 3, Name = "Sting", Quantity = 150, Price = 15.0 };
            Product p4 = new Product { Id = 4, Name = "247", Quantity = 120, Price = 18.0 };
            Product p5 = new Product { Id = 5, Name = "Xá xị", Quantity = 80, Price = 25.0 };
            Product p6 = new Product { Id = 6, Name = "Tiger", Quantity = 60, Price = 30.0 };
            Product p7 = new Product { Id = 7, Name = "Heniken", Quantity = 44, Price = 20.0 };
            Product p8 = new Product { Id = 8, Name = "333", Quantity = 52, Price = 40.0 };
            Product p9 = new Product { Id = 9, Name = "Bia sư tử", Quantity = 10, Price = 41 };
            Product p10 = new Product { Id = 10, Name = "Rượu", Quantity = 45, Price = 10.0 };
            Product p11 = new Product { Id = 11, Name = "Khoai lang chiên", Quantity = 75, Price = 20.0 };
            Product p12 = new Product { Id = 12, Name = "khoai lang nướng", Quantity = 21, Price = 30.0 };
            Product p13 = new Product { Id = 13, Name = "Bắp nướng", Quantity = 15, Price = 40.0 };
            Product p14 = new Product { Id = 14, Name = "snack", Quantity = 20, Price = 50.0 };
            Product p15 = new Product { Id = 15, Name = "xúc xích", Quantity = 53, Price = 10.0 };

            c1.Products.Add(p1.Id, p1);
            c1.Products.Add(p2.Id, p2);
            c1.Products.Add(p3.Id, p3);
            c1.Products.Add(p4.Id, p4);
            c1.Products.Add(p5.Id, p5);
            c2.Products.Add(p6.Id, p6);
            c2.Products.Add(p7.Id, p7);
            c2.Products.Add(p8.Id, p8);
            c2.Products.Add(p9.Id, p9);
            c2.Products.Add(p10.Id, p10);
            c3.Products.Add(p11.Id, p11);
            c3.Products.Add(p12.Id, p12);
            c3.Products.Add(p13.Id, p13);
            c3.Products.Add(p14.Id, p14);
            c3.Products.Add(p15.Id, p15);



            return categories;
        }
    }
}
