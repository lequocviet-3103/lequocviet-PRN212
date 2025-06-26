using BusinessObjects;
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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private Customers currentCustomer;

        public CustomerWindow()
        {
            InitializeComponent();
            currentCustomer = new Customers();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            // Pass the currentCustomer instance to the VieworderWindow constructor
            var viewWindow = new VieworderWindow(currentCustomer);
            viewWindow.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new EditPersonalProfileWindow();
            editWindow.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
