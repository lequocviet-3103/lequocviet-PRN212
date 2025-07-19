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

namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly IOrderService orderService;
        public CustomerWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string customerName = Session.CurrentCustomer.ContactName;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var orders = orderService.GetOrderByNameAndProduct(customerName, searchText);
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = orders;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PersonalProfileCustomerWindow personalProfileCustomerWindow = new PersonalProfileCustomerWindow();
            personalProfileCustomerWindow.ShowDialog();
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
           

            int customerId = Session.CurrentCustomer.CustomerId;        
            var order = orderService.GetAllOrderDetailsByCustomerId(customerId);
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = order;
        }
    }
}
