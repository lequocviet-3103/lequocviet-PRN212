using System;

namespace BusinessObjects;

public partial class OrderReportViewModel
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string EmployeeName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
} 