using DemoLINQ2ObjectModelClass;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();

/*
 * câu 1: lọc ra các sản phẩm có giá từ a tới b
 */
var result = lp.FillterProductsByPrice(100, 200);
Console.WriteLine("các sản phẩm từ 100-200");
result.ForEach(x => Console.WriteLine(x));

/*
 * câu 2: sắp xếp các sản phẩm theo đơn giá tăng dần
 */
var result2 = lp.SortProductsByPriceAsc();
Console.WriteLine("các sản phẩm sau khi sắp xếp asc");
result2.ForEach(x => Console.WriteLine(x));


/*
 * câu 3: sắp xếp desc
 */
var result3 = lp.SortProductsByPriceDesc();
Console.WriteLine("các sản phẩm sau khi sắp xếp desc");
result3.ForEach(x => Console.WriteLine(x));

/*
 * câu 4: tính tổng giá trị các sản phẩm trong kho hàng
 */

Console.WriteLine("tổng giá trị kho hàng = " + lp.SomeOfValue());

/*
 * câu 5: tìm chi tiết sản phẩm khi chưa khi biết mã sản phẩm
 */

Product p = lp.SearchProductDetail(30);
if(p != null)
{
    Console.WriteLine("tìm thấy sản phẩm thông tin chi tiết: ");
    Console.WriteLine(p);
}else
{
    Console.WriteLine("ko tìm thấy sản phẩm");
}

/*
 * câu 6: viết hàm lọc ra top N sản phẩm có trị giá lớn nhất
 */

var result4 = lp.GetTopNProduct(3);
Console.WriteLine("danh sach sản phẩm có trị giá lớn nhất");
result4.ForEach(x => Console.WriteLine(x+"=>" + x.Quantity * x.Price));
