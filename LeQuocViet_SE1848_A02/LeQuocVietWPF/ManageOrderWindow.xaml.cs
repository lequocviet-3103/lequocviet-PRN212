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
    /// Interaction logic for ManageOrderWindow.xaml
    /// </summary>
    public partial class ManageOrderWindow : Window
    {
        private readonly IOrderService orderService;
        public ManageOrderWindow()
        {
            InitializeComponent();
            orderService = new OrderService(); 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            var order = orderService.GetAllOrderDetails();
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = order;

        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CUOrderWindow order = new CUOrderWindow();
            order.ShowDialog();
            LoadOrderList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            
            var selectedVM = lvOrder.SelectedItem as OrderViewModel;
            if (selectedVM == null)
            {
                MessageBox.Show("Please select a service to update.", "select on", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            // Lấy lại Order và OrderDetail từ DB dựa vào thông tin của selectedVM
            var order = orderService.GetOrderById(selectedVM.OrderId);
            var orderDetail = order.OrderDetails.FirstOrDefault(od => od.ProductId == selectedVM.ProductId);

            CUOrderWindow orderWindow = new CUOrderWindow();
            orderWindow.EditedOne = order;
            orderWindow.EditedOD = orderDetail;
            orderWindow.ShowDialog();
            LoadOrderList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Order? selected = lvOrder.SelectedItem as Order;
            if (selected == null)
            {
                MessageBox.Show("Please select a service to delete.", "select on", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            MessageBoxResult answer = MessageBox.Show("Are you sure.", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
            {
                return;
            }
            orderService.DeleteOrder(selected);
            LoadOrderList();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string customerName = txtSearchCus.Text.Trim().ToLower();
            string productName = txtSearchPro.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(customerName) && string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a search term.", "Search Order", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var filteredOrders = orderService.GetOrderByNameAndProduct(customerName, productName);
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = filteredOrders;
        }
    }
}
