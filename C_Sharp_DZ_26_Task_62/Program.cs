void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            Console.Write("0");
            Console.Write($"{matrix[i, j]} \t"); 
        }
        Console.WriteLine();
    }    
}

void Snake (int[,] matrix)
{
    int i = 0;
    int j = 0;
    int vector = 0;
    for (int el = 1; el <= matrix.GetLength(0) * matrix.GetLength(1); el++)
    {    
        matrix[i, j] = el;
    
        if ( vector == 0 ) 
        {   if (j + 1 == matrix.GetLength(1) || matrix[i, j + 1] > 0) 
            {    vector = 1; i++;   }
            else j++;
        }
        else if ( vector == 1)
        {   if (i + 1 == matrix.GetLength(0) || matrix[i + 1, j] > 0)
            {   vector = 2; j--;    }
            else i++;
        }
        else if ( vector == 2)
        {   if (j - 1 < 0 || matrix[i, j - 1] != 0)
            {   vector = 3; i--;    }
            else j--;
        }
        else if ( vector == 3)
        {   if (i - 1 < 0 || matrix[i - 1, j] != 0)
            {   vector =0; j++;     }
            else i--;
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы : ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();
Snake(matrix);
PrintArray(matrix);




