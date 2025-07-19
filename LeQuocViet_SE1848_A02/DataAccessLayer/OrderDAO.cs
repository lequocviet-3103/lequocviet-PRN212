using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        public List<Order> GetOrders()
        {
            using var context = new LucySalesDataContext();
            return context.Orders.ToList();
        }
        public Order GetOrderById(int OrderId)
        {
            using var context = new LucySalesDataContext();
            return context.Orders.FirstOrDefault(p => p.OrderId == OrderId);
        }
        public void AddOrder(Order order)
        {
            using var context = new LucySalesDataContext();
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            using var context = new LucySalesDataContext();
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            using var context = new LucySalesDataContext();
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using var context = new LucySalesDataContext();
            context.OrderDetails.Update(orderDetail);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            using var context = new LucySalesDataContext();
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public List<OrderViewModel> GetAllOrderDetails()
        {
            using var context = new LucySalesDataContext();
            return (from o in context.Orders
                    join c in context.Customers on o.CustomerId equals c.CustomerId
                    join e in context.Employees on o.EmployeeId equals e.EmployeeId
                    join od in context.OrderDetails on o.OrderId equals od.OrderId
                    join p in context.Products on od.ProductId equals p.ProductId
                    select new OrderViewModel
                    {
                        OrderId = o.OrderId,
                        CustomerId = o.CustomerId,
                        CustomerName = c.ContactName,
                        EmployeeId = o.EmployeeId,
                        EmployeeName = e.Name,
                        OrderDate = o.OrderDate,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        UnitPrice = od.UnitPrice,
                        Quantity = od.Quantity,
                        Discount = od.Discount
                    }).ToList();
        }

        public List<OrderViewModel> GetAllOrderDetailsByCustomerId(int cusID)
        {
            using var context = new LucySalesDataContext();
            return GetAllOrderDetails().Where(o => o.CustomerId == cusID).ToList();

        }

            public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            using var context = new LucySalesDataContext();
            var orders = from o in context.Orders
                         where o.OrderDate >= fromDate && o.OrderDate <= toDate
                         join c in context.Customers on o.CustomerId equals c.CustomerId
                         join e in context.Employees on o.EmployeeId equals e.EmployeeId
                         join od in context.OrderDetails on o.OrderId equals od.OrderId
                         group new { o, c, e, od } by new { o.OrderId, c.ContactName, e.Name, o.OrderDate } into g
                         orderby g.Key.OrderDate descending
                         select new OrderReportViewModel
                         {
                             OrderId = g.Key.OrderId,
                             CustomerName = g.Key.ContactName,
                             EmployeeName = g.Key.Name,
                             OrderDate = g.Key.OrderDate,
                             TotalAmount = g.Sum(x => x.od.UnitPrice * x.od.Quantity * (1 - (decimal)x.od.Discount))
                         };
            return orders.ToList();
        }

        public List<OrderViewModel> GetOrderByNameAndProduct(string customer, string product)
        {
            using var context = new LucySalesDataContext();
            return context.Orders
                .Where(o => o.Customer.ContactName.Contains(customer) && o.OrderDetails.Any(od => od.Product.ProductName.Contains(product)))
                .SelectMany(o => o.OrderDetails.Select(od => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    CustomerId = o.CustomerId,
                    CustomerName = o.Customer.ContactName,
                    EmployeeId = o.EmployeeId,
                    EmployeeName = o.Employee.Name,
                    OrderDate = o.OrderDate,
                    ProductId = od.ProductId,
                    ProductName = od.Product.ProductName,
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity,
                    Discount = od.Discount
                })).ToList();
        }

        public List<OrderViewModel> GetOrderByProduct(string product)
        {
            using var context = new LucySalesDataContext();
            return context.Orders
                .Where(o=> o.OrderDetails.Any(od => od.Product.ProductName.Contains(product)))
                .SelectMany(o => o.OrderDetails.Select(od => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    CustomerId = o.CustomerId,
                    CustomerName = o.Customer.ContactName,
                    EmployeeId = o.EmployeeId,
                    EmployeeName = o.Employee.Name,
                    OrderDate = o.OrderDate,
                    ProductId = od.ProductId,
                    ProductName = od.Product.ProductName,
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity,
                    Discount = od.Discount
                })).ToList();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            using var context = new LucySalesDataContext();
            context.OrderDetails.Remove(orderDetail);
            context.SaveChanges();
        }

        }
}
