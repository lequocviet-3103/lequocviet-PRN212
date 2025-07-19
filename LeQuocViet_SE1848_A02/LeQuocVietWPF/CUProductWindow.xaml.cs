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
    /// Interaction logic for CUProductWindow.xaml
    /// </summary>
    public partial class CUProductWindow : Window
    {
        private readonly IProductService iProductService;
        public Product EditedOne { get; set; }
        public CUProductWindow()
        {
            InitializeComponent();
            iProductService = new ProductService();
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtSave_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            //product.ProductId=txtProductID.Text;
            product.ProductName = txtProductName.Text;
            product.SupplierId = int.Parse(txtSupplierID.Text);
            product.QuantityPerUnit = txtQuantity.Text;
            product.UnitPrice = decimal.Parse(txtPrice.Text);
            product.UnitsInStock = int.Parse(txtStock.Text);
            product.UnitsOnOrder = int.Parse(txtUnitOrder.Text);
            product.ReorderLevel = int.Parse(txtReorder.Text);
            product.Discontinued = bool.Parse(txtDiscount.Text); 
            product.CategoryId = (int)cboCategory.SelectedValue;
            if (EditedOne == null)
            {
                iProductService.AddProduct(product);
            }
            else
            {
                product.ProductId = int.Parse(txtProductID.Text);
                //EditedOne.ProductName = txtProductName.Text;
                //EditedOne.SupplierId = int.Parse(txtSupplierID.Text);
                //EditedOne.QuantityPerUnit = txtQuantity.Text;
                //EditedOne.UnitPrice = decimal.Parse(txtPrice.Text);
                //EditedOne.UnitsInStock = int.Parse(txtStock.Text);
                //EditedOne.UnitsOnOrder = int.Parse(txtUnitOrder.Text);
                //EditedOne.ReorderLevel = int.Parse(txtReorder.Text);
                //EditedOne.Discontinued = bool.Parse(txtDiscount.Text);
                //EditedOne.CategoryId = (int)cboCategory.SelectedValue;
                iProductService.UpdateProduct(product);
            }
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBox();
            txtProductID.IsEnabled = false;
            if (EditedOne != null)
            {
                FillElements();
            }

        }

        private void FillComboBox()
        {
            cboCategory.ItemsSource = iProductService.GetCategories();
            cboCategory.DisplayMemberPath = "CategoryName";
            cboCategory.SelectedValuePath = "CategoryId";
        }

        private void FillElements()
        {
            if (EditedOne != null)
            {
                txtProductID.Text = EditedOne.ProductId.ToString();
                txtProductName.Text = EditedOne.ProductName;
                txtSupplierID.Text = EditedOne.SupplierId.ToString();
                txtQuantity.Text = EditedOne.QuantityPerUnit;
                txtPrice.Text = EditedOne.UnitPrice.ToString();
                txtStock.Text = EditedOne.UnitsInStock.ToString();
                txtUnitOrder.Text = EditedOne.UnitsOnOrder.ToString();
                txtReorder.Text = EditedOne.ReorderLevel.ToString();
                txtDiscount.Text = EditedOne.Discontinued.ToString();
                cboCategory.SelectedValue = EditedOne.CategoryId;
            }
        }
    }
}
