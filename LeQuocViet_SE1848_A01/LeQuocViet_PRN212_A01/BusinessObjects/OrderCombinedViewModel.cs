using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderCombinedViewModel
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public decimal Total => UnitPrice * Quantity * (1 - (decimal)Discount);
    }
}
