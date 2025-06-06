using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee obama = new FulltimeEmployee();
obama.Id = 1;
obama.IdCard = "123";
obama.Name = "Barac Obama";
obama.Birthday = new DateTime(1960, 12, 25);
Console.WriteLine("thông tin của Obama");
Console.WriteLine("ID="+ obama.Id);
Console.WriteLine("ID Card" + obama.IdCard);
Console.WriteLine("Name = " + obama.Name);
Console.WriteLine("Birthday = "+obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của obama => " + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1954, 1, 15),
    WorkingHour = 2

};

Console.WriteLine("thông tin của Trump");
Console.WriteLine("ID=" + trump.Id);
Console.WriteLine("ID Card" + trump.IdCard);
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("Birthday = " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của trump => " + trump.calSalary());


Console.WriteLine("------thông tin cách 2 của nhân sự-----------");
Console.WriteLine(obama);
Console.WriteLine(trump);