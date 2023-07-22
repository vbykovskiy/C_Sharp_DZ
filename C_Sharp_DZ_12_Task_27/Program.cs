int f(int n)
{
    int sum  = 0;
    while (n > 0)
    {
        int per = n % 10;
        sum = sum + per;
        n /= 10;
    }
    return sum;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));