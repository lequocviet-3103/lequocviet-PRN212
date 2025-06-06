using DemoAliasClone;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Customer c1 = new Customer();
c1.Id = 1;
c1.Name = "Trần Thị Tèo";

Customer c2 = new Customer();
c2.Id = 2;
c2.Name = " Nguyễn văn Tẹt";

c1 = c2;
//c1 trỏ tới vùng nhớ mà c2 đang quản lý
//chứ ko phải c1 bằng c2
//=> lúc này xảu ra 2 tình hướng
//(1) ô nhớ alpha mà c1 quản lý lúc nãy bị trống
//ko còn đối tượng nào tham gia quản lý nữa
//=> hệ điều hành sẽ thu hồi ô nhớ alpha này
//gọi là cơ chế gom rác tự động: automatic garbage collection
//ta ko thể nào lấy đc giá trị tại ô nhớ này nữa
//(2) lúc này ô nhớ beta sẽ có 2 đối tượng tham gia quản lý
//-đối tượng ban đầu là c2;
//bây giờ có thêm đối tượng c1 quản lý
//trường hợp 1 ô nhớ từ 2 đối tượng trở lên tham gia quản lý nó gọi là alias
//bất kỳ 1 đối tượng nào đổi giá trị tại ô nhớ beta --> thì các đối tượng còn lại đều bị ảnh hưởng
c1.Name = "hồ đồ";
//thì lúc này c2 cũng bị đổi thành hồ đồ
//vì c1 và c2 đang quản lý 1 ô nhớ
Console.WriteLine("tên của c2 = " + c2.Name);
Customer c3 = new Customer();
Customer c4 = c3;
c3 = c1;

Product p1 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};
Product p2 = new Product()
{
    Id = 2,
    Name = "P2",
    Quantity = 15,
    Price = 22
};

p1 = p2;
Console.WriteLine("---thông tin của p1---");
Console.WriteLine(p1);
Console.WriteLine("---thông tin của p2---");
Console.WriteLine(p2);
p2.Name = "Thuốc trị hôi néch";
p2.Quantity = 50;
p2.Price = 100;
Console.WriteLine("---khi thông tin của p2 đổi---");
Console.WriteLine(p1);

Product p3 = new Product()
{
    Id = 3,
    Name = "P2",
    Quantity = 15,
    Price = 22
};

Product p4 = new Product()
{
    Id = 4,
    Name = "P2",
    Quantity = 15,
    Price = 22
};

Product p5 = p3;
p3 = p4;
//hệ điều hành có thu hồi ô nhớ đã cấp phát cho p3 quản lý trước đó hay ko.
//nếu bỏ sung
p5 = p3;

Product p6= p4.Clone();
//HĐH sao chép toàn bộ dữ liệu trong ô nhớ mà p4 đang quản lý qua 1 ô nhớ mới 
//p4 và p6 quản lý 2 ô nhớ khác nhau hoàn toàn, nhưng có giá trị giống nhau
//==> p6 đổi ko liên can p4, và ngược lại
Console.WriteLine("---thông tin của p4---");
Console.WriteLine(p4);
Console.WriteLine("---thông tin của p6---");
Console.WriteLine(p6);
p4.Name = "THuốc trị xàm";
Console.WriteLine("---thông tin của p4---");
Console.WriteLine(p4);
Console.WriteLine("---thông tin của p6---");
Console.WriteLine(p6);