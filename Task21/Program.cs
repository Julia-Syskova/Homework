int x1 = tochka("x", "A");
int y1 = tochka("y", "A");
int z1 = tochka("z", "A");
int x2 = tochka("x", "B");
int y2 = tochka("y", "B");
int z2 = tochka("z", "B");

int tochka(string name1, string name2)
{
    Console.Write($"Введите координату {name1} точки {name2}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double distance(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double length =  Math.Round (distance(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками равно {length}");