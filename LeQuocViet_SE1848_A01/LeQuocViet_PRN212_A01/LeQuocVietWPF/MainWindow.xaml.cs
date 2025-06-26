using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            var manageCustomersWindow = new ManageCustomersWindow();
            manageCustomersWindow.ShowDialog();
        }

        private void btnManageProducts_Click(object sender, RoutedEventArgs e)
        {
            var manageProductsWindow = new ManageProductsWindow();
            manageProductsWindow.ShowDialog();
        }

        

        private void btnCreateAndViewOrders_Click(object sender, RoutedEventArgs e)
        {
            var createAndViewWindow = new CreateAndViewWindow();
            createAndViewWindow.ShowDialog();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            var reportWindow = new ReportWindow();
            reportWindow.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}