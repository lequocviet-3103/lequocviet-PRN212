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

namespace CheckBoxEvent
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


        private void ChkToanBo_Checked(object sender, RoutedEventArgs e)
        {
            ChkCongNghe.IsChecked = true;
            ChkDuLich.IsChecked = true;
            ChkDaBong.IsChecked = true;
            ChkXemPhim.IsChecked = true;
        }

        private void ChkToanBo_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkCongNghe.IsChecked = false;
            ChkDuLich.IsChecked = false;
            ChkDaBong.IsChecked = false;
            ChkXemPhim.IsChecked = false;
        }

        

        private void ChkSub_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if(ChkCongNghe.IsChecked == true &&
               ChkDuLich.IsChecked == true &&
               ChkDaBong.IsChecked == true &&
               ChkXemPhim.IsChecked == true)
            {
                ChkToanBo.IsChecked = true;
            }
            else if(ChkCongNghe.IsChecked == false &&
                    ChkDuLich.IsChecked == false &&
                    ChkDaBong.IsChecked == false &&
                    ChkXemPhim.IsChecked == false)
            { 
                ChkToanBo.IsChecked = false;
            }
        }
    }
}