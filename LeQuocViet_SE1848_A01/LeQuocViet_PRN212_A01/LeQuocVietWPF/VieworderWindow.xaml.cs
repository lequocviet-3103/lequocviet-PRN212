using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Collections.Specialized.BitVector32;

namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for VieworderWindow.xaml
    /// </summary>
    public partial class VieworderWindow : Window
    {
        private Customers currentCustomer;
        private IOrderService orderService;
        public VieworderWindow(Customers customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            orderService = new OrderService();
            LoadOrderHistory();
        }

       
             private void LoadOrderHistory()
        {
            int customerId = Session.CurrentCustomer?.CustomerID ?? 0;
            var orderHistory = orderService.GetOrdersByCustomerId(customerId);
            list.ItemsSource = orderHistory;
        }
    
    }
}
