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
using System.Xml.Linq;

namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for PersonalProfileCustomerWindow.xaml
    /// </summary>
    public partial class PersonalProfileCustomerWindow : Window
    {
        private readonly ICustomerService iCustomerService;
        private Customer customer;
        public PersonalProfileCustomerWindow()
        {
            InitializeComponent();
            iCustomerService = new CustomerService();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Customer data is not loaded.");
                return;
            }
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            iCustomerService.UpdateCustomer(customer);
            Session.CurrentCustomer = customer;
            MessageBox.Show("Profile updated successfully.", "Update Profile", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
            Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            customer = Session.CurrentCustomer;
            if (customer != null)
            {
                customer = Session.CurrentCustomer;
                txtCustomerId.Text = customer.CustomerId.ToString();
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
            }
        }
    }
}
