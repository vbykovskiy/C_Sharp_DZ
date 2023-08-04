void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t"); 
        }
        Console.WriteLine();
    }    
}


void SortRowArr(int[,] matrix)
{
    int temp = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[n, i] < matrix[n, j])
                {
                    temp = matrix[n, i];
                    matrix[n, i] = matrix[n, j];
                    matrix[n, j] = temp;    
                }
            }
        }
    }
    
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();
InputArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortRowArr(matrix);
PrintArray(matrix);