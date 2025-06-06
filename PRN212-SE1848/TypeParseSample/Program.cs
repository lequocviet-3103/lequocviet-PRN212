//đề bài
//nhập vào 1 số >= 0, nếu nhập sai bắt nhập lại;
//nếu nhập đúng ==> tính giai thừa của nó

int n = -1;
while (n < 0)
{
    Console.WriteLine("nhập n >= 0");
    string s = Console.ReadLine();
    if(int.TryParse(s, out n) == false)
    {
        Console.WriteLine("bạn phải nhập số");
    }
    else
    {
        if(n<0)
        {
            Console.WriteLine("bạn phải nhập n>0 hoặc n=0");
        }
    }
}

int gt = 1;
for (int i = 1; i<=n; i++)
{
    gt *= i;
}
Console.WriteLine($"{n}!= {gt}");