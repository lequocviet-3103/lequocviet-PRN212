using BusinessObjects;
using Repositories;
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
    /// Interaction logic for ManageCustomerWindow.xaml
    /// </summary>
    public partial class ManageCustomerWindow : Window
    {
        private readonly ICustomerService customerService;

        public ManageCustomerWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Search Customer", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            var filteredCustomers = customerService.GetCustomersByContactName(searchText);
            lvCustomer.ItemsSource = null;
            lvCustomer.ItemsSource = filteredCustomers;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CUCustomerWindow cUCustomerWindow = new CUCustomerWindow();
            cUCustomerWindow.ShowDialog();
            LoadCustomerList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Customer selected = lvCustomer.SelectedItem as Customer;
            if (selected == null)
            {
                MessageBox.Show("Please select a customer to update.", "Update Customer", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CUCustomerWindow details = new CUCustomerWindow();
            details.EditedOne = selected;
            details.ShowDialog();
            LoadCustomerList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Customer selected = lvCustomer.SelectedItem as Customer;
            if (selected == null)
            {
                MessageBox.Show("Please select a customer to delete.", "Delete Customer", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete custome?", "Delete Customer", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            customerService.DeleteCustomer(selected);
            LoadCustomerList();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomerList();

        }

        private void LoadCustomerList()
        {
            var customers = customerService.GetAllCustomers();
            lvCustomer.ItemsSource = null;
            lvCustomer.ItemsSource = customers;
        }
    }
}
