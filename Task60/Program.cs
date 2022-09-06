Console.WriteLine("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] massiv = new int[x, y, z];
FillArray(massiv);
PrintArray(massiv);

void FillArray(int[,,] massiv)
{
  int[] temp = new int[massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < massiv.GetLength(0); x++)
  {
    for (int y = 0; y < massiv.GetLength(1); y++)
    {
      for (int z = 0; z < massiv.GetLength(2); z++)
      {
        massiv[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
      //Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < massiv.GetLength(1); k++)
      {
        Console.Write($"[{i},{j},{k}] = {massiv[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}