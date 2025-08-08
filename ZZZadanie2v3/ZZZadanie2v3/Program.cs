
Console.WriteLine("Сколько строк?");
int a;
char d;
string a2 = Console.ReadLine();
if (!int.TryParse(a2, out a))
    return;
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
string d2 = Console.ReadLine();
if (!char.TryParse(d2, out d))
    return;
foreach (char z in line)
{
    if(z == d) e++;
}
Console.WriteLine(e);
