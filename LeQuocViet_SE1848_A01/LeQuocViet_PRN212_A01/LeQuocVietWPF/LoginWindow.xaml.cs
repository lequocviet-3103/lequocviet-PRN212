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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private IEmployeeService iEmployeeService;
        private ICustomerService iCustomerService;
        public LoginWindow()
        {
            InitializeComponent();
            iEmployeeService = new EmployeeService();
            iCustomerService = new CustomerService();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Employees employee = iEmployeeService.Login(username, password);
            if (employee != null)
            {
                // Nếu là Admin
                if (employee.JobTitle == "Admin")
                {
                    var mainWindow = new MainWindow(); mainWindow.Show();
                }
                else
                {
                    var customerWindow = new CustomerWindow(); customerWindow.Show();
                }
                this.Close();
            }
            else
            {
                // Kiểm tra login cho customer (Phone + Password)
                Customers customer = iCustomerService.LoginByCustomer(username, password);
                if (customer != null)
                {
                    Session.CurrentCustomer = customer;
                    new CustomerWindow().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username/phone or password!", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
