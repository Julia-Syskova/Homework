Console.WriteLine("Введите пятизначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int a = chislo;
int b = 0;

while (a !=0)
{
    b = b * 10 + a % 10;
    a /= 10;
}

if (chislo == b)
{
    Console.WriteLine("Да");
}
 else
 {
    Console.WriteLine("Нет");
 }

