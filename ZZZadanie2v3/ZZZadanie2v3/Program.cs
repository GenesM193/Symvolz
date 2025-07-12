
Console.WriteLine("Сколько строк?");
int a = Convert.ToInt32(Console.ReadLine());
int e = 0;
Console.WriteLine("Введите информацию из этих строк");
String line = "";
while (a != 0)
{
    line = line + Console.ReadLine();
    a--;
}
int b = line.Length - 1;
Console.WriteLine("Какие символы посчитать?");
char d = Convert.ToChar(Console.ReadLine());
foreach (char z in line)
{
    if(z == d) e++;
}
Console.WriteLine(e);
