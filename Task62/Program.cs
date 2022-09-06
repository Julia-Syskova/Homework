int n = 4;
int[,] massiv = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= massiv.GetLength(0) * massiv.GetLength(1))
{
  massiv[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < massiv.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= massiv.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > massiv.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(massiv);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
