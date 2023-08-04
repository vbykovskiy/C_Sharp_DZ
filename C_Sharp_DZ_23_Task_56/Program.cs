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


void MinStr(int[,] matrix)
{
    int temp = 0;
    int SumElInRow = matrix.GetLength(0) * 10;
    int NumStrMin = 0;
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        temp = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            temp += matrix[n, i];
        }
        if (SumElInRow > temp)
        {
            SumElInRow = temp;
            NumStrMin = n;
        } 
        Console.WriteLine($"Сумма элементов в строке {n + 1} равна {temp}");
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов № {NumStrMin + 1}");
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();
InputArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinStr(matrix);
