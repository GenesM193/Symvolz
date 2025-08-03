
Console.WriteLine("Сколько строк?");
int a;
string a2 = Console.ReadLine();
bool a1 = int.TryParse(a2, out a);
int e = 0;
Console.WriteLine("Введите информацию из этих строк");
String line = "";
while (a != 0)
{
    line = line + Console.ReadLine();
    a--;
}
int b = line.Length-1;
Console.WriteLine("Какие символы посчитать?");
char d = Convert.ToChar(Console.ReadLine());
while (b != -1)
{
    char x = line[b];
    if (d == x) e++;
    b--;
}
Console.WriteLine(e);
