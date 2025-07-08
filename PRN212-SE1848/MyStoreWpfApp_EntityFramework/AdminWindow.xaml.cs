using MyStoreWpfApp_EntityFramework.Models;
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

namespace MyStoreWpfApp_EntityFramework
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        public AdminWindow()
        {
            InitializeComponent();
            LoadCategoryIntoTreeView();
        }

        private void LoadCategoryIntoTreeView()
        {
            //Tạo gốc cây tree view item
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng cát lái";
            tvCategory.Items.Add(root);
            //truy vấn toàn bộ danh mục
            var categories = context.Categories.ToList();
            //đưa danh mục lên tree view
            foreach (var category in categories)
            {
                //tạo node  danh mục 
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category; //lưu id của danh mục vào tag
                root.Items.Add(cate_node);
                //lọc sản phẩm theo danh mục
                var products = context.Products.Where(x => x.CategoryId == category.CategoryId).ToList();
                //nạp product vào danh mục tương ứng
                foreach (var product in products)
                {
                    //tạo node sản phẩm
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product; //lưu id của sản phẩm vào tag
                    cate_node.Items.Add(product_node);
                }

            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
                return;
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item == null)
                return;
            Category category = item.Tag as Category;
            if (category == null)
                return;
            LoadProductsIntoListView(category);
        }


        private void LoadProductsIntoListView(Category category)
        {
            //lọc Sản phẩm theo danh mục:
            var products = context.Products
                .Where(x => x.CategoryId == category.CategoryId)
                .ToList();
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0)
            {
                return;
            }
            Product product = e.AddedItems[0] as Product;
            DisplayProductDetail(product);
        }
        void DisplayProductDetail(Product product)
        {
            if (product == null)
            {
                txtId.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                return;
            }
            else
            {
                txtId.Text = product.ProductId + "";
                txtName.Text = product.ProductName + "";
                txtQuantity.Text = product.UnitsInStock + "";
                txtPrice.Text = product.UnitPrice + "";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayProductDetail(null);
            txtId.Focus();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //bước 1: tìm danh mục mà ta muốn lưu product vào
                //bước 2 tạo product muốn lưu
                //bước 3 gán giá trị cho các thuộc tính của product và lưu
                //bước 4 thực hiện lưu cập nhật lại thư viện tree view và list view

                //---chi tiết
                //bước 1: tìm danh mục mà ta muốn lưu product vào
                TreeViewItem cate_note = tvCategory.SelectedItem as TreeViewItem;
                if (cate_note == null)
                {
                    MessageBox.Show("Bạn cần chọn Danh mục trước", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);

                    return;
                }
                Category category = cate_note.Tag as Category;
                if (category == null)
                {
                    MessageBox.Show("Bạn cần chọn Danh mục trước", "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //bước 2 tạo product muốn lưu
                Product product = new Product();
                //bước 3 gán giá trị cho các thuộc tính của product và lưu
                product.ProductName = txtName.Text;
                product.UnitsInStock = short.Parse(txtQuantity.Text);
                product.UnitPrice = decimal.Parse(txtPrice.Text);
                product.CategoryId = category.CategoryId; //gán id của danh mục cho product
                context.Products.Add(product);
                context.SaveChanges();
                //bước 4 thực hiện lưu cập nhật lại thư viện tree view và list view.
                //bước 4.1 Nạp lại tree view - tạo product node cho cate node
                TreeViewItem product_node = new TreeViewItem();
                product_node.Header = product.ProductName;
                product_node.Tag = product;
                cate_note.Items.Add(product_node);
                //bước 4.2 Nạp lại list view - hiển thị sản phẩm vừa thêm
                LoadProductsIntoListView(category);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tè le: " + ex.Message, "Lỗi lưu sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //tìm sản phẩm muốn sửa trước
                //bước 2: tiến hành thay đổi giá trị các thuộc tính
                // bước 3: lưu thay đổi
                //bước 4: cập nhật lại giao diện tree view và list view
                //---chi tiết---
                int id = int.Parse(txtId.Text);
                Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần sửa, check lại ID", "Lỗi sửa", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //bước 2: tiến hành thay đổi giá trị các thuộc tính
                product.ProductName = txtName.Text;
                product.UnitsInStock = short.Parse(txtQuantity.Text);
                product.UnitPrice = decimal.Parse(txtPrice.Text);
                //bước 3: lưu thay đổi
                context.SaveChanges();
                //bước 4: cập nhật lại giao diện tree view và list view
                //tự làm trong 15p
                //bước 4.1: nạp lại các product node cho cate node
                TreeViewItem cate_note = tvCategory.SelectedItem as TreeViewItem;

                if (cate_note != null)
                {
                    Category category = cate_note.Tag as Category;
                    if (category != null)
                    {
                        //xóa toàn bộ node con cũ của cate node
                        cate_note.Items.Clear();
                        //nạp lại
                        //lọc sản phẩm theo danh mục
                        var products = context.Products.Where(x => x.CategoryId == category.CategoryId).ToList();
                        //nạp product vào danh mục tương ứng
                        foreach (var product_update in products)
                        {
                            //tạo node sản phẩm
                            TreeViewItem product_node = new TreeViewItem();
                            product_node.Header = product_update.ProductName;
                            product_node.Tag = product_node; //lưu id của sản phẩm vào tag
                            cate_note.Items.Add(product_node);
                        }
                        //bước 4.2: nạp lại list view - hiển thị sản phẩm vừa sửa
                        LoadProductsIntoListView(category);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tè le: " + ex.Message, "Lỗi sửa sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //bước 1: tìm sản phẩm muốn xóa
                //bước 2: hỏi xác thực có muốn xóa hay ko
                //bước 3: tiến hành xóa nếu đồng ý
                //bước 4: cập nhật lại giao diện tree view và list view
                //---chi tiết---
                //bước 1: tìm sản phẩm muốn xóa
                int id = int.Parse(txtId.Text);
                Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
                if (product == null)
                {
                    MessageBox.Show($"Không tìm thấy sản phẩm nào có mã = {id} để xóa", "Lỗi xóa", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //bước 2: hỏi xác thực có muốn xóa hay ko
                MessageBoxResult result = MessageBox.Show($"Thím có chắc chắn muốn xóa sản phẩm  {product.ProductName} không?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    return; //không xóa nữa
                }
                //bước 3: tiến hành xóa nếu đồng ý
                context.Products.Remove(product);
                context.SaveChanges();
                //bước 4: cập nhật lại giao diện tree view và list view
                //(bắt chước chức năng cập nhật)
                TreeViewItem cate_note = tvCategory.SelectedItem as TreeViewItem;

                if (cate_note != null)
                {
                    Category category = cate_note.Tag as Category;
                    if (category != null)
                    {
                        //xóa toàn bộ node con cũ của cate node
                        cate_note.Items.Clear();
                        //nạp lại
                        //lọc sản phẩm theo danh mục
                        var products = context.Products.Where(x => x.CategoryId == category.CategoryId).ToList();
                        //nạp product vào danh mục tương ứng
                        foreach (var product_update in products)
                        {
                            //tạo node sản phẩm
                            TreeViewItem product_node = new TreeViewItem();
                            product_node.Header = product_update.ProductName;
                            product_node.Tag = product_node; //lưu id của sản phẩm vào tag
                            cate_note.Items.Add(product_node);
                            
                        }
                            LoadProductsIntoListView(category); //nạp lại list view
                            DisplayProductDetail(null); //xóa thông tin hiển thị chi tiết sản phẩm
                        //bước 4.2: nạp lại list view - hiển thị sản phẩm vừa xóa
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tè le: " + ex.Message, "Lỗi xóa sản phẩm", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
