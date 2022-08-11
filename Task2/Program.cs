Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = 0, min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
