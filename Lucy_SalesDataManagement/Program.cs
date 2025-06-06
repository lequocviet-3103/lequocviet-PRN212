
using Lucy_SalesDataManagement;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//khai báo chuỗi kết nối csdl
string connectionString = "server=LAPTOP-SO1L2O2Q\\LEQUOCVIET;database=Lucy_SalesData;uid=sa; pwd=12345";

Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//câu 1: lọc ra toàn bộ khách hàng
var dskh = context.Customers.ToList();
Console.WriteLine("---danh sách khách hàng---");
foreach (var d in dskh)
{
    Console.WriteLine(d.CustomerID + "\t" + d.ContactName);
}
//câu 2 tìm chi tiết thông tin khách hàng 
//khi biết mã khách hàng
int makh = 10;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == makh);
if (cust != null)
{
    Console.WriteLine("--- chi tiết khachs hàng");
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}

//câu 3 từ kết quả của câu 3 lọc ra danh sách các hóa đơn của khách hàng
//các cột dữ liệu gồn: mã hóa đơn  + ngày hóa đơn
if (cust != null)
{
    var dshd = cust.Orders.Select(od=> new { od.OrderID, od.OrderDate }).ToList();
    var dshd2 = from od in cust.Orders select new { od.OrderID, od.OrderDate };
    Console.WriteLine("danh sách hóa đơn của khách hàng");
    foreach (var od in dshd)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}

//câu 4: từ kq của câu 3 bổ sung thêm cột trị giá của đơn hàng cho mỗi đơn hàng
if (cust != null)
{
    var dshd = cust.Orders.Select(od => new { od.OrderID, od.OrderDate, TotalValue=od.Order_Details.Sum(odd=> odd.Quantity * odd.UnitPrice *(1-(decimal)odd.Discount)) }).ToList();

    Console.WriteLine("danh sách hóa đơn của khách hàng");
    foreach (var od in dshd)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy")+"\t"+ od.TotalValue);
    }
}