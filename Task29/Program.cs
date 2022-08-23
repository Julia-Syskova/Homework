void RandArray()
{
    Console.Write("Введите кол-во элементов в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int [] arr = new int [N];

    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(a,b);
    }
Console.Write("[");
    for (int i = 0; i < N; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
}
RandArray();
Console.Write("]");

