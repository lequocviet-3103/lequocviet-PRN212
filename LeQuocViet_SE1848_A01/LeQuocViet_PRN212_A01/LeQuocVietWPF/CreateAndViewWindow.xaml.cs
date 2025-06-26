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
    /// Interaction logic for CreateAndViewWindow.xaml
    /// </summary>
    public partial class CreateAndViewWindow : Window
    {
        private readonly OrderService orderService;
        private readonly CustomerService customerService;
        private readonly EmployeeService employeeService;
        private readonly ProductService productService;

        public CreateAndViewWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
            customerService = new CustomerService();
            employeeService = new EmployeeService();
            productService = new ProductService();
            LoadOrders();
        }

        private void LoadOrders()
        {
            cbCustomer.ItemsSource = customerService.GetAllCustomers();
            cbCustomer.DisplayMemberPath = "ContactName";
            cbCustomer.SelectedValuePath = "CustomerID";

            cbEmployee.ItemsSource = employeeService.GetAllEmployees();
            cbEmployee.DisplayMemberPath = "Name";
            cbEmployee.SelectedValuePath = "EmployeeID";
            cbProduct.ItemsSource = productService.GetAllProducts();
            cbProduct.DisplayMemberPath = "ProductName";
            cbProduct.SelectedValuePath = "ProductID";
            lvOrders.ItemsSource = orderService.GetOrderCombinedView();
        }


        private void txtCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int customerId = (int)cbCustomer.SelectedValue;
                int employeeId = (int)cbEmployee.SelectedValue;
                int productId = (int)cbProduct.SelectedValue;
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                float discount = float.Parse(txtDiscount.Text);
                orderService.CreateSingleProductOrder(customerId, employeeId, productId, unitPrice, quantity, discount);
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
