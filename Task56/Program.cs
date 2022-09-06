Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[m, n];
FillArray(massiv);
PrintArray(massiv);
int index = 0;
int minsum = Int32.MaxValue;

OrderArray(massiv);
Console.WriteLine($"Строка с наименьшей суммой элементов под номером: {index}");

void OrderArray(int[,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
    {
      int sum = 0;
      for (int j = 0; j < massiv.GetLength(1); j++)
      {
         sum = sum + massiv[i, j];        
      }
      if (sum < minsum)
        {
          minsum = sum;
          index++;
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


