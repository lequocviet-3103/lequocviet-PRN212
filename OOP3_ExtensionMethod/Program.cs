using OOP3_ExtensionMethod;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
int n1 = 5;
int n2 = 10;
Console.WriteLine($"tổng từ 1 đến {n1} = {n1.TongTu1ToN()}");
Console.WriteLine($"tổng từ 1 đến {n2} = {n2.TongTu1ToN()}");
Console.WriteLine($"tổng từ 1 đến 8 = {8.TongTu1ToN()}");

Console.WriteLine("8+7 = " + 8.Cong(7));

int[] m = new int[8];
m.TaoMang();
Console.WriteLine("mảng sau khi tạo ngẫu nhiên: ");
m.XuatMang();

m.SapXepMangTangDan();
Console.WriteLine("Mảng sau khi sắp xếp tăng dần: ");
m.XuatMang();

int[] m2 = m.SapXepMangGiamDan();
Console.WriteLine("Mảng sau khi sắp xếp giảm dần: ");
m.XuatMang();