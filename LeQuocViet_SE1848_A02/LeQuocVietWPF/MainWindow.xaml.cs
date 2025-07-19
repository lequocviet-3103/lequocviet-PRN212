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

        private void btnManagecustomers_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomerWindow manageCustomerWindow = new ManageCustomerWindow();
            manageCustomerWindow.ShowDialog();
        }

        private void btnManageproducts_Click(object sender, RoutedEventArgs e)
        {
            ManageProductWindow manageProductWindow = new ManageProductWindow();
            manageProductWindow.ShowDialog();
        }

        private void btnManageorders_Click(object sender, RoutedEventArgs e)
        {
            ManageOrderWindow manageOrderWindow = new ManageOrderWindow();
            manageOrderWindow.ShowDialog();
        }

        private void btnManageemployees_Click(object sender, RoutedEventArgs e)
        {
            PersonalProfileWindow personalProfileWindow = new PersonalProfileWindow();
            personalProfileWindow.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.ShowDialog();
        }
    }
}