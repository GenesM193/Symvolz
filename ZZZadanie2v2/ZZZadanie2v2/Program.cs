Console.WriteLine("Сколько строк?");
int a;
char d;
string a2 = Console.ReadLine();
if (!int.TryParse(a2, out a))
    return;

int e = 0;
Console.WriteLine("Введите информацию из этих строк");
String line = "";
for (int i = a; i !=0; i--)
{
    line = line + Console.ReadLine();
}
int b = line.Length - 1;
Console.WriteLine("Какие символы посчитать?");
string d2 = Console.ReadLine();
if (!char.TryParse(d2, out d))
    return;
for (int j = b; j !=-1; j--)
{
    char x = line[j];
    if (d == x) e++;
}
Console.WriteLine(e);

