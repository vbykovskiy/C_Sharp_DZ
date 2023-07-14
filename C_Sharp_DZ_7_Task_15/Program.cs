Console.Clear();
void threechar(ref int x)
{
    while (x < 1 || x > 7)
    {
    Console.WriteLine("Неверное число");
    Console.Write("Введите номер дня недели = ");
    x = Convert.ToInt32(Console.ReadLine());
    }
    if(x == 6 || x == 7)
    Console.WriteLine("Выходной");
    else
    Console.WriteLine("не выходной");
}

Console.Write("Введите номер дня недели = ");
int n = Convert.ToInt32(Console.ReadLine());
threechar(ref n);