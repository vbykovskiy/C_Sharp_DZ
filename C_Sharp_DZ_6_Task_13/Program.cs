Console.Clear();
void threechar(ref int x)
{
    if(x < 100)
    Console.WriteLine("Третьего числа нет");
    else
    {
    while (x >= 1000)
    x = x / 10;
    Console.WriteLine($"Третье число {x % 10}");
    }
}

Console.Write("Введите трехзначное число = ");
int n = Convert.ToInt32(Console.ReadLine());
threechar(ref n);