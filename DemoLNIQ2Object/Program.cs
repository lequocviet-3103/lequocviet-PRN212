// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding =Encoding.UTF8;
int[] arr = { 100, 50, 120, 130, 80, 70, 123, 17, 237 };
/*
 * câu 1: dùng linq 2 object để lọc ra 2 số chẵn
 * 
 */
var result = arr.Where(x => x % 2 == 0);
//cách query syntax
var result2 = from x in arr where x % 2 == 0 select x;
Console.WriteLine("danh sách các số chẵn");
result.ToList().ForEach(x => Console.WriteLine(x));
//câu 2: sắp xếp các danh sách răng dần
var result3 = arr.OrderBy(x => x);
var result4 = from x in arr orderby x select x;
Console.WriteLine("\n danh sách sau khi sắp xếp");
foreach (var item in arr)
{
    Console.WriteLine(item+ "\t");
}

//câu 3: sắp xếp danh sách giảm dần
var result5 = arr.OrderByDescending(x => x);
var result6 = from x in arr orderby x descending select x;

//câu 4: đếm số lượng các số lẻ 
int dem = arr.Where(x => x % 2 != 0).Count();


