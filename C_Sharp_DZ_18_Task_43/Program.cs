//y = k1*x + b1 & y = k2*x + b2
//y = k1*((b2-b1)/(k1-k2))+b1

string[,] createmap(string[,] map)
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if (j == map.GetLength(1) / 2) map[i, j] = "|";
            else if (i == map.GetLength(0) / 2) map[i, j] = "=";
            else map[i, j] = ".";
        }
    }
    return(map);
}

void printmap(string[,] picmap)
{
    //перевернуть столбцы
    string temp; 
    for (int j = 0; j < picmap.GetLength(0); j++)
    {
        for (int i = 0; i < picmap.GetLength(1) / 2; i++)
        {
            temp = picmap[i, j];
            picmap[i, j] = picmap[picmap.GetLength(0) - 1 -i, j ];
            picmap[picmap.GetLength(0) - 1 -i, j ] = temp;
        }
    }   
    // напечатать построчно
    for (int i = 0; i < picmap.GetLength(0); i++)
    {
        for (int j = 0; j < picmap.GetLength(1); j++)
        Console.Write($"{picmap[i, j]}");
        Console.WriteLine();
    } 
}

string[,] picline(string[,] linemap, int b1, int k1, int CountDot)
{
    for ( int x = -CountDot; x <= CountDot; x++)
    {
        int y = k1 * x + b1;
        if (y > linemap.GetLength(1)/3) break;
        else
        linemap[x+linemap.GetLength(0) /2, y + linemap.GetLength(1) / 2] = "0";
    }
    return(linemap);
}

void dotcross(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("прямые параллельны");
    else if (k1 == k2) Console.WriteLine("координаты прямых совпадают");
    else
    {
        double y = (b2-b1)/(k1-k2);
        double x = k1*((b2-b1)/(k1-k2))+b1;
        Console.WriteLine($"Точка пересечения ({(x*100)/100} // {(y*100)/100})");
    }
}

string[,] maps = new string[201, 201];
createmap(maps);
//printmap(maps);

Console.Clear();
Console.Write("Введите угловой коэффициент для первой линии: ");
Int32 k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение смещения по оси x: ");
Int32 b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите угловой коэффициент для второй линии: ");
Int32 k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение смещения по оси x: ");
Int32 b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество точек линии: ");
Int32 CountDot = Convert.ToInt32(Console.ReadLine());

picline(maps, b1, k1, CountDot);
picline(maps, b2, k2, CountDot);

printmap(maps);
dotcross(k1, b1, k2, b2);