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
        

        private readonly OrderRepository orderRepository;
    private readonly List<Customers> customers;
    private readonly List<Employees> employees;
    private readonly List<Products> products;

    public OrderService()
    {
            orderRepository = new OrderRepository();
        customers = new List<Customers>();
        employees = new List<Employees>();
        products = new List<Products>();
    }

        public void CreateSingleProductOrder(int customerId, int employeeId, int productId, decimal unitPrice, int quantity, float discount)
        {
            var detail = new OrderDetails
            {
                ProductID = productId,
                UnitPrice = unitPrice,
                Quantity = quantity,
                Discount = discount
            };

            CreateOrderWithDetail(customerId, employeeId, detail);
        }

        public List<OrderCombinedViewModel> GetOrdersByCustomerId(int customerId)
        {
            return orderRepository.GetOrdersByCustomerId(customerId);
        }


        public void AddOrder(Orders order)
        {
             orderRepository.AddOrder(order);
        }

        public bool DeleteOrder(int orderId)
        {
            return orderRepository.DeleteOrder(orderId);
        }

        public bool DeleteOrder(Orders order)
        {
            return orderRepository.DeleteOrder(order);
        }

        public List<Orders> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }

        public Orders GetOrderById(int orderId)
        {
            return orderRepository.GetOrderById(orderId);
        }

        public void UpdateOrder(Orders order)
        {
            orderRepository.UpdateOrder(order);
        }

        public void CreateOrderWithDetail(int customerId, int employeeId, OrderDetails detail)
        {
            orderRepository.CreateOrderWithDetail(customerId, employeeId, detail);
        }

        public List<OrderCombinedViewModel> GetOrderCombinedView()
        {
            return orderRepository.GetOrderCombinedView();
        }

        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate)
        {
            return orderRepository.GetOrdersReport(fromDate, toDate);
        }
    }
}
