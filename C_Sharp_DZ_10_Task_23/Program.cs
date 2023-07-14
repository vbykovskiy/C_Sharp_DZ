Console.Clear();
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int i = 0; i <= n; i++)
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");