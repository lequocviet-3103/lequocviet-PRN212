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
    /// Interaction logic for ReportsWindow.xaml
    /// </summary>
    
    
    public partial class ReportsWindow : Window
    {
        private readonly IOrderService orderService;
        public ReportsWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void txtSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtStart.SelectedDate == null || txtEnd.SelectedDate == null)
            {
                MessageBox.Show("Please select both From and To dates.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            

            DateTime from = txtStart.SelectedDate.Value;
            DateTime to = txtEnd.SelectedDate.Value;

            var reportData = orderService.GetOrdersReport(from, to);
            lvReports.ItemsSource = reportData;
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
