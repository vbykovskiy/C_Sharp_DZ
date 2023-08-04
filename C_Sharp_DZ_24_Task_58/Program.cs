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


void ProizvedMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] ProMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        for (int i = 0; i < matrix2.GetLength(1); i++)
        {
            for (int j = 0; j < matrix2.GetLength(0); j++)
            {
                ProMatrix[n,i] += matrix[n, j] * matrix2[j, i];
            } 
        }
    }
    PrintArray(ProMatrix);
}


Console.Clear();
Console.Write("Введите размеры матрицы 1 : ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите размеры матрицы 2 : ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
Console.WriteLine();
InputArray(matrix);
PrintArray(matrix);
Console.WriteLine();
InputArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
ProizvedMatrix(matrix, matrix2);

