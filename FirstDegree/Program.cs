using System.Runtime.Intrinsics.X86;
using System.Text;

void first_degree_solution(double a, double b)
{
    if(a == 0 && b == 0)
        Console.WriteLine("vô số nghiệm");
    else if (a == 0 && b != 0)
        Console.WriteLine("vô nghiệm");
    else 
        Console.WriteLine("x = {0}", -b/a);
}

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("phương trình bậc 1: ax + b = 0");
Console.WriteLine("nhập hệ số a");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("nhập hệ số b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x + {1} = 0", a, b);
first_degree_solution(a, b);
Console.ReadLine();