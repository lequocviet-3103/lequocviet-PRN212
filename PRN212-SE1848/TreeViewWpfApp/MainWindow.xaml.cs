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
using TreeViewWpfApp.Model;

namespace TreeViewWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataSet.GenerateDataset();
        public MainWindow()
        {
            InitializeComponent();
            DisplayDataIntoTreeView();
        }

        private void DisplayDataIntoTreeView()
        {
            //xóa dữ liễu cũ đi
            tvCategory.Items.Clear();
            //tạo nút gốc
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Bình Dương";
            tvCategory.Items.Add(root);
            //vòng lặp 1: nạp toàn bộ danh mục lên cây
            foreach (KeyValuePair<int, Category> item in categories)
            {
                Category cate = item.Value;
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = cate;
                root.Items.Add(cate_node);
                //vòng lặp 2: nạp toàn bộ sản phẩm danh mịc lên cây
                foreach (KeyValuePair<int, Product> subItem in cate.Products)
                {
                    Product p = subItem.Value;
                    //tạo product node
                    TreeViewItem p_node = new TreeViewItem();
                    p_node.Header = p;
                    //đưa p node lên cate node
                    cate_node.Items.Add(p_node);
                }
            }

        }
    }
}