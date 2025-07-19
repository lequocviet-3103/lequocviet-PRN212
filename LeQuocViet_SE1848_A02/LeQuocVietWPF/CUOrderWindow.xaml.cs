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
    /// Interaction logic for CUOrderWindow.xaml
    /// </summary>
    public partial class CUOrderWindow : Window
    {
        private readonly IOrderService orderService;
        public Order EditedOne { get; set; }
        public OrderDetail EditedOD { get; set; }
        public CUOrderWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void txtSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int orderId = int.Parse(txtOrderId.Text);
                int customerId = int.Parse(txtCustomerId.Text);
                int employeeId = int.Parse(txtEmployeeId.Text);
                DateTime orderDate = dtpDate.SelectedDate ?? DateTime.Now;
                int productId = int.Parse(txtProductId.Text);
                decimal unitPrice = decimal.Parse(txtPrice.Text);
                short quantity = short.Parse(txtQuantity.Text);
                float discount = float.Parse(txtDiscount.Text);

                if (EditedOne == null) // ADD
                {
                    // Tạo mới Order
                    var newOrder = new Order
                    {
                        OrderId = orderId, 
                        CustomerId = customerId,
                        EmployeeId = employeeId,
                        OrderDate = orderDate,
                        OrderDetails = new List<OrderDetail>()
                    };

                    // Lưu Order trước để lấy OrderId
                    orderService.AddOrder(newOrder);

                    // Tạo mới OrderDetail
                    var newOrderDetail = new OrderDetail
                    {
                        OrderId = newOrder.OrderId, // đã có sau khi lưu Order
                        ProductId = productId,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        Discount = discount
                    };

                    // Lưu OrderDetail
                    orderService.AddOrderDetail(newOrderDetail);

                    MessageBox.Show("Order và OrderDetail đã được thêm thành công!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "\nInner: " + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    msg += "\nInner2: " + ex.InnerException.InnerException.Message;
                MessageBox.Show("Error: " + msg);
            }
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            if(EditedOne !=null)
            {
                FillElements();
            }
        }
        private void FillElements()
        {
            if (EditedOne != null && EditedOD != null)
            {
                txtOrderId.Text = EditedOne.OrderId.ToString();
                txtCustomerId.Text = EditedOne.CustomerId.ToString();
                txtEmployeeId.Text = EditedOne.EmployeeId.ToString();
                dtpDate.SelectedDate = EditedOne.OrderDate;
                txtProductId.Text = EditedOD.ProductId.ToString();
                txtQuantity.Text = EditedOD.Quantity.ToString();
                txtPrice.Text = EditedOD.UnitPrice.ToString();
                txtDiscount.Text = EditedOD.Discount.ToString();
            }
        }
    }
}
