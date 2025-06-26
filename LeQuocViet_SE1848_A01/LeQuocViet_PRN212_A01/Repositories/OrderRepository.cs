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
        OrderDAO orderDAO = new OrderDAO();

        public void AddOrder(Orders order)
        {
             orderDAO.AddOrder(order);
        }

        public void CreateOrderWithDetail(int customerId, int employeeId, OrderDetails detail)
        {
            orderDAO.CreateOrderWithDetail(customerId, employeeId, detail);
        }

        public bool DeleteOrder(int orderId)
        {
            return orderDAO.DeleteOrder(orderId);
        }

        public bool DeleteOrder(Orders order)
        {
            return orderDAO.DeleteOrder(order);
        }

        public List<Orders> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }

        public Orders GetOrderById(int orderId)
        {
            return orderDAO.GetOrderById(orderId);
        }

        public List<OrderCombinedViewModel> GetOrderCombinedView()
        {
            return orderDAO.GetOrderCombinedView();
        }

        public List<OrderCombinedViewModel> GetOrdersByCustomerId(int customerId)
        {
            return orderDAO.GetOrdersByCustomerId((int) customerId);
        }

        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            return orderDAO.GetOrdersReport(fromDate, toDate);
        }

        public void UpdateOrder(Orders order)
        {
            orderDAO.UpdateOrder(order);
        }
    }
}
