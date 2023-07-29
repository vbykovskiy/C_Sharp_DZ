void InputArray(Double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) * 0.1;
            Console.Write($"{Math.Round(matrix[i, j], 1)} \t");
        }
        Console.WriteLine();
    }
        
}

void CheckEl(Double[,] matrix, int[] Elp)
{
    if (Elp[0] < matrix.GetLength(0)
    && Elp[1] < matrix.GetLength(1))
    Console.WriteLine($"Значение элемента {Math.Round(matrix[Elp[0], Elp[1]], 1)}");
    else
    Console.WriteLine("за пределами матрицы");
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Double[,] matrix = new Double[size[0], size[1]];
InputArray(matrix);

Console.Write("Введите позицию элемента (строка столбец): ");
int[] Elp = Console.ReadLine().Split(" ").Select(x => int.Parse(x) -1).ToArray();
CheckEl(matrix, Elp);