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
        private readonly ICustomerService iCustomerService;
        private readonly IEmployeeService iEmployeeService;
        public LoginWindow()
        {
            InitializeComponent();
            iCustomerService = new CustomerService();
            iEmployeeService = new EmployeeService();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = iCustomerService.GetCustomerByPhone(txtUsername.Text.Trim());
            Employee employee = iEmployeeService.GetEmployeeByUserName(txtUsername.Text.Trim());
            if (employee != null && employee.Password.Equals(txtPassword.Password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Session.CurrentEmployee = employee; 
                this.Close();
            }
            else if (customer != null)
            {
                Session.CurrentCustomer = customer;
                CustomerWindow customerWindow = new CustomerWindow();
                customerWindow.Show();
               
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
