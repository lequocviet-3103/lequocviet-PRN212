string do_math(double a, double b, string op)
{
    string result = "";
    switch (op)
    {
        case "+":
            result = $"{a} + {b} = {a + b}";
            break;
        case "-":
            result = $"{a} - {b} = {a - b}";
            break;
        case "*":
            result = $"{a} * {b} = {a * b}";
            break;
        case "/":
            if (b == 0) result = "mẫu số khác 0";
            else result = $"{a} / {b} = {a / b}";
            break;
        default:
            result = "Nhập phép toán tào lao quá";
            break;

    }
    return result;
}

double a, b;
Console.WriteLine("nhạp a: ");
a=double.Parse(Console.ReadLine());
Console.WriteLine("nhạp b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Phép toán +  - * /: ");
string op = Console.ReadLine();
string  result = do_math(a, b, op); 
Console.WriteLine(result);
