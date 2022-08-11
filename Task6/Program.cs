Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int mod = number % 2;

if (mod == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}