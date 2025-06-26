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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private readonly OrderService orderService;

        public ReportWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            if (dpFrom.SelectedDate == null || dpTo.SelectedDate == null)
            {
                MessageBox.Show("Please select both From and To dates.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DateTime from = dpFrom.SelectedDate.Value;
            DateTime to = dpTo.SelectedDate.Value;

            var reportData = orderService.GetOrdersReport(from, to);
            lvReports.ItemsSource = reportData;
        }
    }

}
