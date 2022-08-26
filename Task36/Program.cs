Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

RandArray(arr);
Console.WriteLine("Массив: ");

PrintArray(arr);
int sum = 0;

for (int n = 1; n < arr.Length; n+=2)
    sum = sum + arr[n];
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");

void RandArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-10,10);
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
