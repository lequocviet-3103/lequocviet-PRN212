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
    /// Interaction logic for EditPersonalProfileWindow.xaml
    /// </summary>
    public partial class EditPersonalProfileWindow : Window
    {
        private ICustomerService iCustomerService;
        private Customers currentCustomer;
        public EditPersonalProfileWindow()
        {
            InitializeComponent();
            CustomerService customerService = new CustomerService();
            iCustomerService = customerService;
            if (Session.CurrentCustomer != null)
            {
                currentCustomer = Session.CurrentCustomer;

                txtCompanyName.Text = currentCustomer.CompanyName;
                txtContactName.Text = currentCustomer.ContactName;
                txtContactTitle.Text = currentCustomer.ContactTitle;
                txtAddress.Text = currentCustomer.Address;
                txtPhone.Text = currentCustomer.Phone;
            }
            else
            {
                MessageBox.Show("No customer data available.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Customer data is not loaded.");
                return;
            }

            currentCustomer.CompanyName = txtCompanyName.Text.Trim();
            currentCustomer.ContactName = txtContactName.Text.Trim();
            currentCustomer.ContactTitle = txtContactTitle.Text.Trim();
            currentCustomer.Address = txtAddress.Text.Trim();
            currentCustomer.Phone = txtPhone.Text.Trim();
            iCustomerService.UpdateCustomer(currentCustomer);
            Session.CurrentCustomer = currentCustomer;
            MessageBox.Show("suscessfully!!!.");
        }
    }
}
