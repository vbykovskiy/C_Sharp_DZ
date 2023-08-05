void number (int num)
{
    if (num > 0)
    {
    Console.Write($"{num} ");
    num -=1; 
    number(num);
    }
    else return;
}

Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
number(num);
