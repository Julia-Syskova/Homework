Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[m, n];
FillArray(massiv);
PrintArray(massiv);

for (int j = 0; j < massiv.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        avarage = (avarage + massiv[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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