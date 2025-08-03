Console.WriteLine("Сколько строк?");
int a;
string a2 = Console.ReadLine();
bool a1 = int.TryParse(a2, out a);
int e = 0;
Console.WriteLine("Введите информацию из этих строк");
String line = "";
for (int i = a; i !=0; i--)
{
    line = line + Console.ReadLine();
}
int b = line.Length - 1;
Console.WriteLine("Какие символы посчитать?");
char d = Convert.ToChar(Console.ReadLine());
for (int j = b; j !=-1; j--)
{
    char x = line[j];
    if (d == x) e++;
}
Console.WriteLine(e);

