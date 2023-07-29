void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t"); 
        }
        Console.WriteLine();
    }
}

void SrArfArr(int[,] matrix, float[] SrArf)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            SrArf[j] += matrix[i, j];
        }
    }
    Console.WriteLine();
    for (int i = 0; i < SrArf.GetLength(0); i++)
    Console.Write($"{SrArf[i] / SrArf.GetLength(0)} \t");
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
float [] SrArf = new float[size[0]];
Console.WriteLine();
InputArray(matrix);
SrArfArr(matrix, SrArf);