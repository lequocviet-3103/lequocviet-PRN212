using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderService
    {
        public List<Orders> GetAllOrders();
        public void AddOrder(Orders order);
        public Orders GetOrderById(int orderId);
        public void UpdateOrder(Orders order);
        public bool DeleteOrder(int orderId);
        public bool DeleteOrder(Orders order);
        public void CreateOrderWithDetail(int customerId, int employeeId, OrderDetails detail);
        public List<OrderCombinedViewModel> GetOrderCombinedView();
        public List<OrderCombinedViewModel> GetOrdersByCustomerId(int customerId);
        public List<OrderReportViewModel> GetOrdersReport(DateTime fromDate, DateTime toDate);
    }
}
