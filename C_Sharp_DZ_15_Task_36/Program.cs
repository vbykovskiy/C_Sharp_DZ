void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 10);
}

int SumNechetPoz(int[] array)
{
int Sum = 0;
for (int i = 0; i < array.Length; i++)
if (i % 2 == 1)
Sum += array[i];
return Sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма чисел на нечетных позициях - {SumNechetPoz(array)}");