Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summa(int number)
{
    int chislo = Convert.ToString(number).Length;
    int a = 0;
    int result = 0;

    for (int i = 0; i < chislo; i++)
    {
      a = number - number % 10;
      result = result + (number - a);
      number = number / 10;
    }
    return result;
}

int sum = summa(number);
Console.WriteLine("Сумма цифр равна: " + sum);
