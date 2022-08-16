int chislo = Read("Введите трехзначное число: ");
int symma = chislo.ToString().Length;

if (symma < 3 || symma > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(Center(chislo));
}

int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Center(int a)
{
    int result = ((a / 10) % 10);
    return result;
}