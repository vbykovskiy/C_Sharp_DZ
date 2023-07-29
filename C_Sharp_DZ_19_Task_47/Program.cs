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

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Double[,] matrix = new Double[size[0], size[1]];
InputArray(matrix);
