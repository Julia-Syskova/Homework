Console.WriteLine("Введите трехзначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int symma = chislo.ToString().Length;

if (symma < 3 || symma > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(Center(chislo));
}

int Center(int a)
{
    int result = ((a / 10) % 10);
    return result;
}