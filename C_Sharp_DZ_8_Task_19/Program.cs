Console.Clear();
void threechar(ref int x)
{
    while (x > 99999 || x < 9999)
    {
    Console.WriteLine("Неверное число");
    Console.Write("Введите пятизначное число = ");
    x = Convert.ToInt32(Console.ReadLine());
    }
    if(x / 10000 == x % 10 && (x % 10000) / 1000 == (x % 100) / 10)
    Console.WriteLine("Число полиндром");
    else
    Console.WriteLine("Число не полиндром");
}

Console.Write("Введите пятизначное число для проверки на палиндром = ");
int n = Convert.ToInt32(Console.ReadLine());
threechar(ref n);