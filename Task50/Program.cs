Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[5, 5];
FillArray(massiv);
PrintArray(massiv);

if (m > massiv.GetLength(0) || n > massiv.GetLength(1))
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно {massiv[m-1,n-1]}");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
