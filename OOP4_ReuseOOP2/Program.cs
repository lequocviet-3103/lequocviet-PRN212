using OOP2;
using OOP4_ReuseOOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.IdCard = "123456";
fe.Birthday = new DateTime(1952,12,25);
Console.WriteLine(fe);
Console.WriteLine("AGE = " + fe.Tuoi());
