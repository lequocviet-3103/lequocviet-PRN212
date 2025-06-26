using System;
using System.Collections.Generic;
using System.Globalization;
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
using BusinessObject;
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        bool isCompleted = false;
        public ProductWindow()
        {
            InitializeComponent();
            isCompleted= false;
            productService.GenerateSampleDataSet();
            lvProduct.ItemsSource = productService.GetProducts();
            isCompleted = true;
        }

        private void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                isCompleted = false;
                Product p = new Product();
                p.Id = int.Parse(txtId.Text);
                p.Name = txtName.Text;
                p.Quantity = int.Parse(txtQuantity.Text);
                p.Price = double.Parse(txtPrice.Text);
                bool result =  productService.SaveProduct(p);
                if(result)
                {
                    lvProduct.ItemsSource = null; // Clear the current items source
                    lvProduct.ItemsSource = productService.GetProducts(); // Refresh the list view with updated products
                
                }
                isCompleted = true;
            }catch (Exception ex)
            {
                MessageBox.Show("lỗi lung tung rồi, chi tiết: " + ex.Message);
            }
            

        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                int id = int.Parse(txtId.Text);
                Product p = productService.GetProduct(id);
                if (p == null) return;//ko tìm thấy để sửa
                //nếu tìm thấy thì thay đổi dữ liệu
                p.Name = txtName.Text;
                p.Quantity = int.Parse(txtQuantity.Text);
                p.Price = double.Parse(txtPrice.Text);
                bool kq = productService.SaveProduct(p);
                if (kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetProducts();
                }

                isCompleted = true;
            }catch (Exception ex)
            {
                MessageBox.Show("lỗi lung tung rồi, chi tiết: " + ex.Message);
            }
            
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isCompleted == false) return; //vì thực hiện thao tác dữ liệu chưa xong
            if (e.AddedItems.Count < 0)
                return; //vì ng dùng chưa chọn cái nào
            //lấy oroduct đang chọn
            Product p = e.AddedItems[0] as Product;
            if(p == null) return;
            txtId.Text = p.Id.ToString();
            txtName.Text = p.Name.ToString();
            txtQuantity.Text = p.Quantity.ToString();
            txtPrice.Text = p.Price.ToString();

        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //luôn luôn phải xác thực có muốn xóa hay ko
                MessageBoxResult ret = MessageBox.Show("bạn muốn xóa sản phẩm này hả? ",//nội dung hỏi của cửa sổ 
                    "xác nhận xóa", //tiêu đề cửa sổ
                    MessageBoxButton.YesNo, //nút hiển thị trên cửa sổ
                    MessageBoxImage.Question //biểu tượng hiển thị trên cửa sổ
                    );
                if(ret == MessageBoxResult.No)
                {
                    return; //người dùng không muốn xóa
                }
                isCompleted = false;
                int id = int.Parse(txtId.Text);
                bool kq = productService.DeleteProduct(id);
                if (kq == false) return;//không tìm thấy sản phẩm để xóa

                lvProduct.ItemsSource = null; // Clear the current items source
                    lvProduct.ItemsSource = productService.GetProducts(); 
                txtId.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                isCompleted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("xóa bị lỗi: " + ex.Message);
            }
        }
    }
}
