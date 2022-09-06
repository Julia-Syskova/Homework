Console.WriteLine("Введите количество строк 1й матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1й матрицы");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк 2й матрицы");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2й матрицы");
int l = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[k, l];
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m,l];

Matrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void Matrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}