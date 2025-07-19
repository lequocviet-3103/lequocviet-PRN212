using BusinessObjects;
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
    /// Interaction logic for ManageProductWindow.xaml
    /// </summary>
    public partial class ManageProductWindow : Window
    {
        private readonly IProductService iProductService;
        private readonly IOrderService iOrderService;
        public ManageProductWindow()
        {
            InitializeComponent();
            iProductService = new ProductService();
            iOrderService = new OrderService();
        }

        private void lvProduct_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProductList(iProductService.GetAllProducts());
        }

        private void LoadProductList(List<Product> arr)
        {
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = arr;
        }

        private void txtAdd_Click(object sender, RoutedEventArgs e)
        {
            CUProductWindow details = new CUProductWindow();
            details.ShowDialog();
            LoadProductList(iProductService.GetAllProducts());
        }

        private void txtUpdate_Click(object sender, RoutedEventArgs e)
        {
            Product selected = lvProduct.SelectedItem as Product;
            if (selected == null)
            {
                MessageBox.Show("Please select a product to update.", "update Product", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CUProductWindow details = new CUProductWindow();
            details.EditedOne = selected;
            details.ShowDialog();
            LoadProductList(iProductService.GetAllProducts());
        }

        private void txtDelete_Click(object sender, RoutedEventArgs e)
        {
            Product selected = lvProduct.SelectedItem as Product;
            if (selected == null)
            {
                MessageBox.Show("Please select a product to delete.", "Delete Product", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBoxResult answer = MessageBox.Show("Are you sure.", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
            {
                return;
            }
            iProductService.DeleteProduct(selected);
            LoadProductList(iProductService.GetAllProducts());
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if(string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Search Product", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var filteredProducts = iProductService.GetProductsByName(searchText);
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = filteredProducts;
        }
    }
}
