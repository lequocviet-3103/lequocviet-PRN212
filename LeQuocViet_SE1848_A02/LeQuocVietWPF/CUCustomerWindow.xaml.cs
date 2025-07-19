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
    /// Interaction logic for CUCustomerWindow.xaml
    /// </summary>
    public partial class CUCustomerWindow : Window
    {
        private readonly ICustomerService customerService;
        public Customer EditedOne { get; set; }
        public CUCustomerWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCustomerId.IsEnabled = false;
            if (EditedOne != null)
            {
                FillElements();
            }
        }

        private void FillElements()
        {
            txtCustomerId.Text = EditedOne.CustomerId.ToString();
            txtComName.Text = EditedOne.CompanyName;
            txtContactName.Text = EditedOne.ContactName;
            txtConTitle.Text = EditedOne.ContactTitle;
            txtPhone.Text = EditedOne.Phone;
            txtAddress.Text = EditedOne.Address;
        }

        

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.CompanyName = txtComName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtConTitle.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            if(EditedOne == null)
            {
                customerService.AddCustomer(customer);
            }
            else
            {
                customer.CustomerId = int.Parse(txtCustomerId.Text);
                //EditedOne.CompanyName = txtComName.Text;
                //EditedOne.ContactName = txtContactName.Text;
                //EditedOne.ContactTitle = txtConTitle.Text;
                //EditedOne.Address = txtAddress.Text;
                //EditedOne.Phone = txtPhone.Text;
                customerService.UpdateCustomer(customer);
                MessageBox.Show("Customer updated successfully.", "Update Customer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Close();
        }
    }
}
