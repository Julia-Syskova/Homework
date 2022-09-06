Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[m, n];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Отсортированный массив: ");
OrderArray(massiv);
PrintArray(massiv);

void OrderArray(int[,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
      for (int k = 0; k < massiv.GetLength(1) - 1; k++)
      {
        if (massiv[i, k] < massiv[i, k + 1])
        {
          int temp = massiv[i, k + 1];
          massiv[i, k + 1] = massiv[i, k];
          massiv[i, k] = temp;
        }
      }
    }
  }
}

void FillArray(int[,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
      massiv[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintArray(int[,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
      Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
  }
}

