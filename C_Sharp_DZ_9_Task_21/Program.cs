Console.Clear();
Console.WriteLine("Введите координаты для расчета расстояния: ");
Console.WriteLine();
int[] array_x = new int[3];
int[] array_y = new int[3];

for (int i = 0; i < array_x.Length; i++)
{
    Console.Write($"x {i+1} = ");
    array_x[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
for (int i = 0; i < array_y.Length; i++)
{
    Console.Write($"y {i+1} = ");
    array_y[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"координата x = [{string.Join(", ", array_x)}]");
Console.WriteLine($"координата y = [{string.Join(", ", array_y)}]");
Console.WriteLine();
Console.Write("Расстояние между координатами = ");
Console.Write(Math.Round(Math.Sqrt(Math.Pow(array_x[0] - array_y[0], 2) + Math.Pow(array_x[1] - array_y[1], 2)+ Math.Pow(array_x[2] - array_y[2], 2)), 3));
Console.WriteLine();