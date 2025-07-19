using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO orderDAO = new OrderDAO();
        public List<Order> GetOrders()
        {
            return orderDAO.GetOrders();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            orderDAO.DeleteOrderDetail(orderDetail);
        }
        public List<OrderViewModel> GetOrderByProduct(string product)
        {
                        return orderDAO.GetOrderByProduct(product);
        }
        public Order GetOrderById(int OrderId)
        {
            return orderDAO.GetOrderById(OrderId);
        }
        public void AddOrder(Order order)
        {
            orderDAO.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            orderDAO.UpdateOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            orderDAO.DeleteOrder(order);
        }
        public List<OrderViewModel> GetAllOrderDetails()
        {
            return orderDAO.GetAllOrderDetails();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDAO.AddOrderDetail(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            orderDAO.UpdateOrderDetail(orderDetail);
        }
        public List<OrderViewModel> GetAllOrderDetailsByCustomerId(int cusID)
        {
           return orderDAO.GetAllOrderDetailsByCustomerId(cusID);
        }
        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            return orderDAO.GetOrdersReport(fromDate, toDate);
        }
        public List<OrderViewModel> GetOrderByNameAndProduct(string customer, string product)
        {
            return orderDAO.GetOrderByNameAndProduct(customer, product);
        }
    }
}
