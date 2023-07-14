Console.Clear();
void twochar(ref int x)
{
    int x1 = x/100;
    x = (x - x1*100) / 10;
    Console.WriteLine($"Второе число = {x}");
}

Console.Write("Введите трехзначное число = ");
int n = Convert.ToInt32(Console.ReadLine());
twochar(ref n);

