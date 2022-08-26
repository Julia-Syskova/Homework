Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

RandArray(arr);
Console.WriteLine("Массив: ");

PrintArray(arr);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < arr.Length; n++)
{
    if (arr[n] > max)
        {
            max = arr[n];
        }
    if (arr[n] < min)
        {
            min = arr[n];
        }
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void RandArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100,1000)/100;
        }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}