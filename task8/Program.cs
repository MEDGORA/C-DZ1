Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2) 
{
    Console.WriteLine("Программа показывает только положительные чётные числа от 1");
}
else
{
    for (int i = 2; i < N+1; i=i+2)
    {
        //Console.Write($"{i}, ");
        string a = ($"{i}, ");
        //a = a.Substring(0, a.Length - 2);
        //a -=", ";
        string b = a;
        //Console.Write(b.Substring(0, b.Length - 2));
        Console.Write(b);
        /*
        string str = i.ToString();
        str = str.Substring(str.Length - 2);
        Console.Write(str);
        /*
        string text = Write($"{i}, ");
        text = text.Substring(0, text.Length - 2);
        Console.WriteLine(text);
        */
    }
}