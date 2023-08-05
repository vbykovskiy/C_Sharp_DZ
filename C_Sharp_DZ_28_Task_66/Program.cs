int number (int num, int num2)
{
    num2 -= 1;
    if (num < num2) return number(num, num2) + num2;
    else return 0;
}

int sum = number(5, 10);
Console.Write(sum);
