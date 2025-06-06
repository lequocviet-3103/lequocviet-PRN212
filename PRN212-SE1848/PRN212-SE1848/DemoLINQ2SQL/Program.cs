using DemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//khai báo chuỗi kết nối tới CSDL
string connectionString = "server=LAPTOP-SO1L2O2Q\\LEQUOCVIET;database=MyStore;uid=sa; pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//câu 1: truy vấn toàn bộ danh mục
var dsdm = context.Categories.ToList();
Console.WriteLine("--Danh sách danh mục---");
foreach (var d in dsdm)
{
    Console.WriteLine(d.CategoryID+"\t"+d.CategoryName);
}

//lấy thông tin chi tiết danh mục khi quét mã
int madm = 7;
Category cate = context.Categories.FirstOrDefault(c=> c.CategoryID ==madm);
if(cate == null)
{
    Console.WriteLine("ko tìm thấy danh mục qua mã = "+madm);
} else
{
    Console.WriteLine("tìm thấy danh mục có mã = "  + madm);
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}

//câu 3: dùng query syntax để truy vấn toàn bộ sản phẩm 
var dssp = from p in context.Products select p;
Console.WriteLine("--- danh sach san phẩm");
foreach (var p in dssp)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

//câu 4: dùng query syntax và anonymous type để lọc ra các sản phẩm nhưng chỉ lấy mã sẩn phẩm và đơn giá đồng thời sắp xếp giảm dần
var dssp4 = from p in context.Products orderby p.UnitPrice descending select new { p.ProductID, p.UnitPrice };
Console.WriteLine("---danh sách sản phẩm theo câu 4");
foreach (var p in dssp4)
{
    Console.WriteLine(p.ProductID + "\t"+ p.UnitPrice);
}

//câu 5 sửa câu  theo extention method (method syntax)
var dssp5 = context.Products.OrderByDescending(p => p.UnitPrice).Select(p => new { p.ProductID, p.UnitPrice });
Console.WriteLine("sửa dssp5");
foreach (var p in dssp5)
{
    Console.WriteLine(p.ProductID + "\t" + p.UnitPrice);
}


//câu 6 lọc ra top 3 sản phẩm có giá lớn nhất hệ thống yêu cầu dùng method syntax
var dssptop3 = context.Products.OrderByDescending(p => p.UnitPrice).Take(3);
Console.WriteLine("top 3 sản phẩm lớn nhất");
foreach (var p in dssptop3)
{
    Console.WriteLine(p.ProductID + "\t" + p.UnitPrice);
}
//câu 7 sửa tên danh mục khi quét nã
int madm_edit = 5;
Category cate_edit = context.Categories.FirstOrDefault(c=> c.CategoryID == madm_edit);
if (cate_edit != null)
{
    cate_edit.CategoryName = "Hàng trôi nổi";
    context.SubmitChanges();//xác nhân lưu thay đổi
}

//câu 8: xóa danh mục  khi biết mã
int madm_xoa = 15;
Category cate_remove = context.Categories.FirstOrDefault(c=> c.CategoryID==madm_xoa);
if (cate_remove != null)
{
    context.Categories.DeleteOnSubmit(cate_remove);
    context.SubmitChanges();//xác thực thay đổi dữ liệu
}

//câu 9 xóa các danh mục nếu ko có bất kỳ sản phẩm nào
//lưu ý: là xóa cùng 1 lúc nhiều danh mục mà các danh mục này ko có chứa bất kỳ 1 sản phẩm nào 
var dsdm_empty_product = context.Categories.Where(c=>c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dsdm_empty_product);
context.SubmitChanges();
//câu 10: thêm mới 1 danh mục:
Category c_new = new Category();
c_new.CategoryName = "Hàng lậu từ Trung Quốc";
context.Categories.InsertOnSubmit(c_new);
context.SubmitChanges();

//câu 11: thêm mới nhiều danh mục 
List<Category> list = new List<Category>();
list.Add(new Category() { CategoryName = "Hàng gia dụng"});
list.Add(new Category() { CategoryName = "Hàng điện tử" });
list.Add(new Category() { CategoryName = "Hàng phụ kiện" });
context.Categories.InsertAllOnSubmit(list);
context.SubmitChanges();


