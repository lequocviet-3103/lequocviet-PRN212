using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataContextSingleton
    {
        private static DataContextSingleton _instance;
        public static DataContextSingleton Instance => _instance ??= new DataContextSingleton();

        public List<Customers> Customers { get; set; }
        public List<Employees> Employees { get; set; }
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Orders> Orders { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }

        private DataContextSingleton()
        {
            SeedData();
        }

        private void SeedData()
        {
            Customers = new List<Customers>
    {
        new Customers { CustomerID = 1, CompanyName = "VNG company", ContactName = "Nguyễn Văn An", ContactTitle = "Manager", Address = "123 Le Loi", Phone = "0909123456", Password = "123" },
        new Customers { CustomerID = 2, CompanyName = "Mailisa", ContactName = "Trần Thị Bình", ContactTitle = "Director", Address = "456 Tran Hung Dao", Phone = "0911222333", Password = "123" },
        new Customers { CustomerID = 3, CompanyName = "Vinamilk", ContactName = "Hoàng Thị Thảo", ContactTitle = "Purchasing", Address = "789 Nguyen Trai", Phone = "0909888777", Password = "123" },
        new Customers { CustomerID = 4, CompanyName = "FPT Software", ContactName = "Lê Văn Cường", ContactTitle = "Lead", Address = "88 Ton Duc Thang", Phone = "0911000000", Password = "123" }
    };

            Employees = new List<Employees>
    {
        new Employees { EmployeeID = 1, Name = "Lê Quốc Việt", UserName = "viet", Password = "123", JobTitle = "Admin" },
        new Employees { EmployeeID = 2, Name = "Nguyễn Văn Cường", UserName = "cuong", Password = "123", JobTitle = "Admin" },
        new Employees { EmployeeID = 3, Name = "Trần Thị Lan", UserName = "lan", Password = "123", JobTitle = "Admin" },
        new Employees { EmployeeID = 4, Name = "Đỗ Thanh Tùng", UserName = "tung", Password = "123", JobTitle = "Admin" }
    };

            Categories = new List<Categories>
    {
        new Categories { CategoryID = 1, CategoryName = "Beverages", Description = "Drinks and beverages" },
        new Categories { CategoryID = 2, CategoryName = "Snacks", Description = "Snack foods" },
        new Categories { CategoryID = 3, CategoryName = "Bakery", Description = "Bread and cakes" }
    };

            Products = new List<Products>
    {
        new Products { ProductID = 1, ProductName = "Coca Cola", CategoryID = 1, UnitPrice = 10000, UnitsInStock = 100 },
        new Products { ProductID = 2, ProductName = "Pepsi", CategoryID = 1, UnitPrice = 9000, UnitsInStock = 80 },
        new Products { ProductID = 3, ProductName = "Potato Chips", CategoryID = 2, UnitPrice = 15000, UnitsInStock = 50 },
        new Products { ProductID = 4, ProductName = "Choco Pie", CategoryID = 3, UnitPrice = 12000, UnitsInStock = 60 },
        new Products { ProductID = 5, ProductName = "Red Bull", CategoryID = 1, UnitPrice = 18000, UnitsInStock = 40 },
        new Products { ProductID = 6, ProductName = "Oreo", CategoryID = 2, UnitPrice = 13000, UnitsInStock = 70 }
    };

            Orders = new List<Orders>
    {
        new Orders { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-5) },
        new Orders { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = DateTime.Now.AddDays(-4) },
        new Orders { OrderID = 3, CustomerID = 3, EmployeeID = 3, OrderDate = DateTime.Now.AddDays(-3) },
        new Orders { OrderID = 4, CustomerID = 1, EmployeeID = 2, OrderDate = DateTime.Now.AddDays(-2) },
        new Orders { OrderID = 5, CustomerID = 4, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-1) }
    };

            OrderDetails = new List<OrderDetails>
    {
        new OrderDetails { OrderID = 1, ProductID = 1, UnitPrice = 10000, Quantity = 2, Discount = 0f },
        new OrderDetails { OrderID = 1, ProductID = 3, UnitPrice = 15000, Quantity = 1, Discount = 0.1f },
        new OrderDetails { OrderID = 2, ProductID = 2, UnitPrice = 9000, Quantity = 3, Discount = 0f },
        new OrderDetails { OrderID = 2, ProductID = 4, UnitPrice = 12000, Quantity = 2, Discount = 0f },
        new OrderDetails { OrderID = 3, ProductID = 5, UnitPrice = 18000, Quantity = 1, Discount = 0.05f },
        new OrderDetails { OrderID = 4, ProductID = 1, UnitPrice = 10000, Quantity = 5, Discount = 0.1f },
        new OrderDetails { OrderID = 4, ProductID = 6, UnitPrice = 13000, Quantity = 2, Discount = 0f },
        new OrderDetails { OrderID = 5, ProductID = 3, UnitPrice = 15000, Quantity = 3, Discount = 0.15f },
        new OrderDetails { OrderID = 5, ProductID = 2, UnitPrice = 9000, Quantity = 2, Discount = 0f }
    };
        }

    }
}
