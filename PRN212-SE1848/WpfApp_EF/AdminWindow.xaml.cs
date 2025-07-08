using BusinessObjects_EF;
using Services_EF;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp_EF
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ICategoryService categoryService = new CategoryService();
        IProductService productService = new ProductService();
        public AdminWindow()
        {
            InitializeComponent();
            LoadCategoryAndProductIntoTreeview();
        }

        private void LoadCategoryAndProductIntoTreeview()
        {
            tvCategory.Items.Clear();
            //tạo nút gốc
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho Hàng cát lái";
            tvCategory.Items.Add(root);
            //nạp toàn bộ danh mục lên cây
            List<Category> categories = categoryService.GetCategories();
            foreach (Category category in categories) {
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);

                //nạp sản phẩm theo danh mục
                List<Product> products = productService.GetProductsByCategory(category.CategoryId);
                category.Products = products;
                foreach (Product product in category.Products)
                {
                    TreeViewItem products_node = new TreeViewItem();
                    products_node.Header = product.ProductName;
                    products_node.Tag = product;
                    cate_node.Items.Add(products_node);
                }
            }
            root.ExpandSubtree();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if(e.NewValue == null)
            {
                return;
            }
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item == null) return;
            List<Product> products = null;
            Object data = item.Tag;

            if(data == null)
            { //người dùng nhấn vào nút gốc
                products = productService.GetProsucts();
            } else if ( data is Category)
            { //người dùng nhấn vào nút category
                Category category = (Category) data;
                products = productService.GetProductsByCategory(category.CategoryId);
            }
            else if (data is Product)
            { //người dùng nhấn vào nút product
                products = new List<Product>();
                products.Add((Product)data);
            }
            //nạp lên list view
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;

        }


        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
