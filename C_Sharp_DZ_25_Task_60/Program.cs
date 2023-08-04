void InputArray(int[,,] matrix)
{
    int x = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n <  matrix.GetLength(2); n++)
            {
                matrix[i, j, n] = x;
                x++;
            }
        }
    }
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                Console.Write($"{matrix[i, j, n]}({i},{j},{n})\t"); 
            }
            Console.WriteLine();
        }
    }    
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
Console.WriteLine();
InputArray(matrix);
PrintArray(matrix);

