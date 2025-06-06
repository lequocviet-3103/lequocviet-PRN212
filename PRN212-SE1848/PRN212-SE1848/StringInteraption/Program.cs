using System.Text;

string ho = "Nguyễn";
string tenlot = "Thị";
string ten = "Tủn";
string full_name = ho + " " + tenlot +  " "+ten;
Console.WriteLine(full_name);

StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());