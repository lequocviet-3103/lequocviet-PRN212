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
using BusinessObjects;


namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for ManageCustomersWindow.xaml
    /// </summary>
    public partial class ManageCustomersWindow : Window
    {
        private readonly ICustomerService customerService;

        public ManageCustomersWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = customerService.GetAllCustomers();
            lstCustomers.ItemsSource = customers;

        }

        private void lstCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCustomers.SelectedItem is Customers selectedCustomer)
            {
                txtCustomerID.Text = selectedCustomer.CustomerID.ToString();
                txtCompanyName.Text = selectedCustomer.CompanyName;
                txtContactName.Text = selectedCustomer.ContactName;
                txtContactTitle.Text = selectedCustomer.ContactTitle;
                txtAddress.Text = selectedCustomer.Address;
                txtPhone.Text = selectedCustomer.Phone;
            }
            else
            {
                txtCustomerID.Clear();
                txtCompanyName.Clear();
                txtContactName.Clear();
                txtContactTitle.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lstCustomers.SelectedItem is Customers selectedCustomer)
            {
                selectedCustomer.CompanyName = txtCompanyName.Text;
                selectedCustomer.ContactName = txtContactName.Text;
                selectedCustomer.ContactTitle = txtContactTitle.Text;
                selectedCustomer.Address = txtAddress.Text;
                selectedCustomer.Phone = txtPhone.Text;

                lstCustomers.Items.Refresh(); // cập nhật lại ListBox
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstCustomers.SelectedItem is Customers selectedCustomer)
            {
                if (MessageBox.Show($"Are you sure you want to delete customer {selectedCustomer.CustomerID}?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var customers = customerService.GetAllCustomers();
                    customers.Remove(selectedCustomer);

                    lstCustomers.ItemsSource = null;
                    lstCustomers.ItemsSource = customers;
                    ClearTextBoxes();

                    MessageBox.Show("Customer deleted successfully.", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void ClearTextBoxes()
        {
            txtCustomerID.Clear();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var customer = customerService.GetAllCustomers();
            var newCustomer = new Customers
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };
            customerService.AddCustomer(newCustomer);
            lstCustomers.ItemsSource = null;
            lstCustomers.ItemsSource = customerService.GetAllCustomers();
            ClearTextBoxes();


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            customerService.GetAllCustomers();
            var filteredCustomers = customerService.GetAllCustomers()
                .Where(c => 
                            c.CustomerID.ToString().Contains(keyword) ||
                            (!string.IsNullOrEmpty(c.ContactName) && c.ContactName.ToLower().Contains(keyword)) ||
        (!string.IsNullOrEmpty(c.Phone) && c.Phone.ToLower().Contains(keyword)))
                .ToList();
            lstCustomers.ItemsSource = filteredCustomers;
            if (filteredCustomers.Count == 0)
            {
                MessageBox.Show("No customers found matching the search criteria.", "Search Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
