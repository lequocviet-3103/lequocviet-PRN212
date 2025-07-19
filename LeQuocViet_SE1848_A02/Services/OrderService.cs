using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            orderRepository.DeleteOrderDetail(orderDetail);
        }

        public List<OrderViewModel> GetOrderByProduct(string product)
        {
            return orderRepository.GetOrderByProduct(product);
        }

        public void AddOrder(Order order)
        {
            orderRepository.AddOrder(order);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderRepository.AddOrderDetail(orderDetail);
        }

        public void DeleteOrder(Order order)
        {
            orderRepository.DeleteOrder(order);
        }

        public List<OrderViewModel> GetAllOrderDetails()
        {
            return orderRepository.
                GetAllOrderDetails();
        }

        public Order GetOrderById(int OrderId)
        {
            return orderRepository.GetOrderById(OrderId);
        }

        public List<Order> GetOrders()
        {
            return orderRepository.GetOrders();
        }

        public void UpdateOrder(Order order)
        {
            orderRepository.UpdateOrder(order);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            orderRepository.UpdateOrderDetail(orderDetail);
        }

        public List<OrderViewModel> GetAllOrderDetailsByCustomerId(int cusID)
        {
            return orderRepository.GetAllOrderDetailsByCustomerId(cusID);
        }
        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            return orderRepository.GetOrdersReport(fromDate, toDate);
        }
        public List<OrderViewModel> GetOrderByNameAndProduct(string customer, string product)
        {
            return orderRepository.GetOrderByNameAndProduct(customer, product);
        }
    }
}
