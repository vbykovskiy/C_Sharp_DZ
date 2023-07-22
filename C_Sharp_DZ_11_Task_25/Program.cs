void f(int a, int b)
{
    if (b == 0)
    Console.WriteLine(1);
    else
    {
    int result = a;
    for (int i = 2; i <= b; i ++)
        result *= a;
    Console.WriteLine(result);
    }
}

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

f(a, b);