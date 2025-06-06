//tạo đối tượng category 1
using OOP1;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước nắm";
c1.PrintInfor();
//giả sử ta đổi giá trị trong ô nhớ đó
c1.Name = "thuốc trị hôi néch";
Console.WriteLine("sau khi đổi giá trị");
c1.PrintInfor();
//sử dụng lớp employee
Console.WriteLine("----------Epmloyee------------");
Employee e1 = new Employee();
e1.Id = 1; //gọi setter của property của id
e1.IdCard = "001";//gọi setter property của IdCard 
e1.Name = "Tèo"; //gọi setter property của name
e1.Email = "teo@gmail.com";//gọi setter property của Email
e1.Phone = "0123456789";//gọi setter property của Phone
//xuất thông tin
e1.PrintInfor();

Employee e2 = new Employee()
{
    Id = 2,
    IdCard = "001",
    Name = "Tý",
    Email = "ty@gmail.com",
    Phone = "0976543"
};
Console.WriteLine("----------Epmloyee 2------------");
e2.PrintInfor();

Employee e3 = new Employee();
Console.WriteLine("----------Epmloyee 3------------");
e3.PrintInfor();

//tạo employee 4
Console.WriteLine("----------Epmloyee 4------------");
Employee e4 = new Employee(4, "004", "tủn", "tun@gmail.com", "0976");
e4.PrintInfor(); 
Console.WriteLine("----------Epmloyee 4 cách 2------------");
Console.WriteLine(e4);

Console.WriteLine("----------CUstomer 1------------");
Customer cus1 = new Customer()
{
    Id = "cus1",
    Name = "Nguyễn thị lung linh",
    Email = "lunglinh@gmail.com",
    Phone = "0976",
    Address = "số 1 - Đinh Tiên Hoàng - Quận 1 - HCM"
};
cus1.PrintInfor();
cus1.Address = "Số 2 - Võ Nguyên Giáp";
Console.WriteLine("customer sau kho sửa đị chỉ");
cus1.PrintInfor();