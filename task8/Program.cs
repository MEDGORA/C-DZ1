Console.Write("Введите число (N): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2) 
{
    Console.WriteLine("Программа показывает только положительные чётные числа от 1 до N, где N больше или равно 2");
}
else
{
    for (int i = 2; i < N+1; i=i+2)
    {
        if (i < N-1)
        {
        Console.Write($"{i}, ");
        }
        else
        {
        Console.Write(i);
        }
    }
}    