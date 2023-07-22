void InputArray(Double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 10) + new Random().NextDouble();
}

Double RaznMaxMin(Double[] array)
{
Double ch_min = array[0];
Double ch_max = array[0];
for (int i = 1; i < array.Length; i++)
    {
    if (ch_max < array[i])
        ch_max = array[i];
    if (ch_min > array[i])
        ch_min = array[i];
    }
return ch_max - ch_min;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Double[] array = new Double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("разница между максимальным и минимальным - ");
Console.Write(String.Format("{0:0.00}", RaznMaxMin(array)));