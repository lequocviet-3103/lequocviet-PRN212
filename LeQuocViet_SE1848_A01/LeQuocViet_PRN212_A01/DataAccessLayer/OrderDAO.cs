using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        private DataContextSingleton context = DataContextSingleton.Instance;
        public List<Orders> GetAllOrders()
        {
            return context.Orders;
        }

        public void CreateOrderWithDetail(int customerId, int employeeId, OrderDetails detail)
        {
            var newOrder = new Orders
            {
                OrderID = context.Orders.Count > 0 ? context.Orders.Max(o => o.OrderID) + 1 : 1,
                CustomerID = customerId,
                EmployeeID = employeeId,
                OrderDate = DateTime.Now
            };

            context.Orders.Add(newOrder);

            detail.OrderID = newOrder.OrderID;
            context.OrderDetails.Add(detail);
        }
        public List<OrderCombinedViewModel> GetOrderCombinedView()
        {
            return (
                from order in context.Orders
                join customer in context.Customers on order.CustomerID equals customer.CustomerID
                join employee in context.Employees on order.EmployeeID equals employee.EmployeeID
                join detail in context.OrderDetails on order.OrderID equals detail.OrderID
                join product in context.Products on detail.ProductID equals product.ProductID
                select new OrderCombinedViewModel
                {
                    OrderID = order.OrderID,
                    CustomerID = customer.CustomerID.ToString(),
                    CustomerName = customer.ContactName,
                    EmployeeName = employee.Name,
                    ProductName = product.ProductName,
                    UnitPrice = detail.UnitPrice,
                    Quantity = detail.Quantity,
                    Discount = detail.Discount
                }).ToList();
        }


        public List<OrderCombinedViewModel> GetOrdersByCustomerId(int customerId)
        {
            return GetOrderCombinedView()
                   .Where(o => o.CustomerID == customerId.ToString())
                   .ToList();
        }




        public void AddOrder(Orders order)
        {
            order.OrderID = context.Orders.Count > 0 ? context.Orders.Max(o => o.OrderID) + 1 : 1;
            context.Orders.Add(order);
        }
        public Orders GetOrderById(int orderId)
        {
            return context.Orders.FirstOrDefault(o => o.OrderID == orderId);
        }
        public void UpdateOrder(Orders order)
        {
            var oldOrder = GetOrderById(order.OrderID);
            if (oldOrder != null)
            {
                oldOrder.OrderID = order.OrderID;
                oldOrder.CustomerID = order.CustomerID;
                oldOrder.EmployeeID = order.EmployeeID;
                oldOrder.OrderDate = order.OrderDate;
            }
        }
        public bool DeleteOrder(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order != null)
            {
                context.Orders.Remove(order);
                return true;
            }
            return false;
        }
        public bool DeleteOrder(Orders order)
        {
            if (order == null) return false;
            return DeleteOrder(order.OrderID);
        }

        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            var orders = from o in context.Orders
                         where o.OrderDate >= fromDate && o.OrderDate <= toDate
                         join c in context.Customers on o.CustomerID equals c.CustomerID
                         join e in context.Employees on o.EmployeeID equals e.EmployeeID
                         join od in context.OrderDetails on o.OrderID equals od.OrderID
                         group new { o, c, e, od } by new { o.OrderID, c.ContactName, e.Name, o.OrderDate } into g
                         orderby g.Key.OrderDate descending
                         select new OrderReportViewModel
                         {
                             OrderID = g.Key.OrderID,
                             CustomerName = g.Key.ContactName,
                             EmployeeName = g.Key.Name,
                             OrderDate = g.Key.OrderDate,
                             TotalAmount = g.Sum(x => x.od.UnitPrice * x.od.Quantity * (1 - (decimal)x.od.Discount))
                         };

            return orders.ToList();
        }

    }
}
