//sử dụng generic list để quant lý nhân sự đầy đủ
//tính năng crud
/*
 * create --> tạo mới dữ liệu
 * read/retrive -> xem, lọc tìm kiếm, sắp xếp, thống kê
 * update
 * delete
 */
//câu 1: tạp 5 nhân viên, 3 nhân viên chính thức, 2 thời vụ
//lưu vào generic list
using OOP2;

    List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Name 1",
    Birthday = new DateTime(1992, 11, 12)
};
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "345",
    Name = "Name 2",
    Birthday = new DateTime(1996, 3, 23)
};
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "789",
    Name = "Name 3",
    Birthday = new DateTime(1995, 5, 15)
};
employees.Add(fe1);
employees.Add(fe2);
employees.Add(fe3);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    IdCard = "234",
    Name = "Name 4",
    Birthday = new DateTime(1999, 1, 14),
    WorkingHour = 2

};

ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    IdCard = "678",
    Name = "Name 5",
    Birthday = new DateTime(1993, 12, 3),
    WorkingHour = 3
};
employees.Add(pe1);
employees.Add(pe2);

//câu 2 xuất toàn bộ nhân sự
Console.WriteLine("câu 2 xuất toàn bộ nhân sự");
employees.ForEach(e => Console.WriteLine(e));


//câu 3: R-> lọc ra các nhân sự là chính thức
//cách 1:
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
//foreach(FulltimeEmployee fe in fe_list)
//    Console.WriteLine(fe);
//câu 4 tính tổng tiền lương cho nhân viên chính thức
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("tổng lương chính thức: ");
Console.WriteLine(fe_sum_salary);
double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
Console.WriteLine("câu 5 tổng tiền lương nhân viên thời vụ");
Console.WriteLine(pe_sum_salary);
//xóa sửa
//sửa thông tin nhân viên
Console.WriteLine("Sửa thông tin nhân viên");
Console.Write("Nhập id bạn muốn sửa: ");
int id = int.Parse(Console.ReadLine());

foreach (Employee emp in employees)
{
    if (emp.Id == id)
    {
        Console.Write("enter Id Card: ");
        string IdCard = Console.ReadLine();
        emp.IdCard = IdCard;
        Console.Write("enter name: ");
        string NewName = Console.ReadLine();
        emp.Name = NewName;
        Console.Write("enter Birthday: ");
        DateTime Birthday = DateTime.Parse(Console.ReadLine());
        emp.Birthday = Birthday;
        if (emp is ParttimeEmployee parttime)
        {
            Console.Write("enter workinghour: ");
            int workingHour = int.Parse(Console.ReadLine());
            parttime.WorkingHour = workingHour;
        }
        Console.WriteLine("In ra thông tin sửa");
        Console.WriteLine(emp);
    }


}

Console.WriteLine("Xóa thông tin nhân viên");
Console.Write("Nhập Id bạn muốn xóa: ");
int DeleteId = int.Parse(Console.ReadLine());
for(int i = 0; i < employees.Count; i++)
{
    if (employees[i].Id == DeleteId)
    {
        employees.RemoveAt(i);
        Console.WriteLine("Xóa thành công");
        
    }
    
}
Console.WriteLine("In thông tin employee đã xóa");
foreach (Employee emp in employees)
{
    
    Console.WriteLine(emp);
}

