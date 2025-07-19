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
            is_load_product_completed = false;
            LoadCategoryAndProductIntoTreeview();
            is_load_product_completed = true;
        }

        bool is_load_product_completed = false;
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
            txtId.Clear();
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtId.Focus();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //chọn danh mục tree view item 
            TreeViewItem cate_node = tvCategory.SelectedItem as TreeViewItem;
            if (cate_node == null)
            {
                MessageBox.Show("chưa chọn danh mục lưu sản phẩm", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Category selectedCaregory = cate_node.Tag as Category;
            if (selectedCaregory == null)
            {
                MessageBox.Show("chưa chọn danh mục lưu sản phẩm", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //tạo sản phẩm mới
            Product product = new();
            product.ProductName = txtName.Text;
            product.UnitPrice = decimal.Parse(txtPrice.Text);
            product.UnitsInStock = short.Parse(txtQuantity.Text);
            product.CategoryId = selectedCaregory.CategoryId;
            bool ret = productService.SaveProduct(product);
            if (ret)
            {//lưu thành công => nạp lại cây cho cate_node + products cho listview
                //nạp lại cate_node
                cate_node.Items.Clear();
                //nạp sản phẩm theo danh mục
                List<Product> products = productService.GetProductsByCategory(selectedCaregory.CategoryId);
                selectedCaregory.Products = products;
                foreach (Product product_update in selectedCaregory.Products)
                {
                    TreeViewItem products_node = new TreeViewItem();
                    products_node.Header = product_update.ProductName;
                    products_node.Tag = product_update;
                    cate_node.Items.Add(products_node);
                }
                //nạp lại list view 
                is_load_product_completed = false;
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
                is_load_product_completed = true;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // chọn danh mục tree view item
                TreeViewItem cate_node = tvCategory.SelectedItem as TreeViewItem;
                if (cate_node == null)
                {
                    MessageBox.Show("chưa chọn danh mục lưu sản phẩm", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Category selectedCaregory = cate_node.Tag as Category;
                if (selectedCaregory == null)
                {
                    MessageBox.Show("chưa chọn danh mục lưu sản phẩm", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //tạo sản phẩm mới
                Product product = new();
                product.ProductId = int.Parse(txtId.Text);
                product.ProductName = txtName.Text;
                product.UnitPrice = decimal.Parse(txtPrice.Text);
                product.UnitsInStock = short.Parse(txtQuantity.Text);
                product.CategoryId = selectedCaregory.CategoryId;
                bool ret = productService.UpdateProduct(product);
                if (ret) {
                    //cập nhật thành công -> nạp lại giao diện
                    cate_node.Items.Clear();
                    //nạp sản phẩm theo danh mục
                    List<Product> products = productService.GetProductsByCategory(selectedCaregory.CategoryId);
                    selectedCaregory.Products = products;
                    foreach (Product product_update in selectedCaregory.Products)
                    {
                        TreeViewItem products_node = new TreeViewItem();
                        products_node.Header = product_update.ProductName;
                        products_node.Tag = product_update;
                        cate_node.Items.Add(products_node);
                    }
                    //nạp lại list view 
                    is_load_product_completed = false;
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                    is_load_product_completed = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi cập nhật sản phẩm: " + ex.Message,
                    "lỗi cập nhật sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TreeViewItem cate_node = tvCategory.SelectedItem as TreeViewItem;
                if (cate_node == null)
                {
                    MessageBox.Show("chưa chọn danh mục xóa sản phẩm", "Lỗi xóa sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Category selectedCaregory = cate_node.Tag as Category;
                if (selectedCaregory == null)
                {
                    MessageBox.Show("chưa chọn danh mục xóa sản phẩm", "Lỗi xóa sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No) return;
                //xóa thì phải luôn luôn hỏi có muốn xóa không
                int productId = int.Parse(txtId.Text);
                bool ret = productService.DeleteProduct(productId);
                if (ret)
                {
                    //xóa dữ liệu trên các ô chi thiết
                    btnClear.RaiseEvent(e);
                    
                    //sau đó nạp lại cây list view
                    cate_node.Items.Clear(); // Clear existing items first to avoid duplicates
                    
                    //nạp lại danh sách sản phẩm theo danh mục
                    List<Product> products = productService.GetProductsByCategory(selectedCaregory.CategoryId);
                    selectedCaregory.Products = products;
                    
                    foreach (Product product_update in selectedCaregory.Products)
                    {
                        TreeViewItem products_node = new TreeViewItem();
                        products_node.Header = product_update.ProductName;
                        products_node.Tag = product_update;
                        cate_node.Items.Add(products_node);
                    }
                    
                    //nạp lại list view 
                    is_load_product_completed = false;
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                    is_load_product_completed = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xóa sản phẩm: " + ex.Message,
                    "lỗi xóa sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            is_load_product_completed = false;
            if (e.NewValue == null)
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
            is_load_product_completed = true;
        }


        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (is_load_product_completed == false) return;
            if (e.AddedItems.Count <= 0) return;
            Product p = e.AddedItems[0] as Product;
            txtId.Text = p.ProductId.ToString();
            txtName.Text = p.ProductName;
            txtQuantity.Text = p.UnitsInStock.ToString();
            txtPrice.Text = p.UnitPrice.ToString();

        }

        private void menusystem_changepassword_Click(object sender, RoutedEventArgs e)
        {
            ResetPasswordWindow resetPassword = new ResetPasswordWindow();
            resetPassword.ShowDialog();
        }
    }
}
