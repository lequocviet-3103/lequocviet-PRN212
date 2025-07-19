using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderService
    {
        public List<Order> GetOrders();
        public Order GetOrderById(int OrderId);
        public void AddOrder(Order order);

        public void UpdateOrder(Order order);

        public void DeleteOrder(Order order);
        public List<OrderViewModel> GetAllOrderDetails();
        public void AddOrderDetail(OrderDetail orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail);
        public List<OrderViewModel> GetAllOrderDetailsByCustomerId(int cusID);
        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate);
        public List<OrderViewModel> GetOrderByNameAndProduct(string customer, string product);
        public List<OrderViewModel> GetOrderByProduct(string product);
        public void DeleteOrderDetail(OrderDetail orderDetail);
    }
}
