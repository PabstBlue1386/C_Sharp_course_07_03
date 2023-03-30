double[] GenerateRandomArray(int sizeMass, int downBorder, int upBorder)
{
    double[] arr = new double[sizeMass];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(random.NextDouble() + (upBorder - downBorder) + upBorder, 2);
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
    Console.WriteLine();
}

double MaxValue(double[] arr)
{
    double max = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    }
    return max;
}

double MinValue(double[] arr)
{
    double min = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    }
    return min;
}
Console.Write("Enter size mass: ");
int sizeMass = int.Parse(Console.ReadLine()!);
Console.Write("Enter down border mass: ");
int downBorder = int.Parse(Console.ReadLine()!);
Console.Write("Enter up border mass: ");
int upBorder = int.Parse(Console.ReadLine()!);

double[] array = GenerateRandomArray(sizeMass, downBorder, upBorder);
PrintArray(array);
double maxValue = MaxValue(array);
double minValue = MinValue(array);

Console.WriteLine($"Min value -> {minValue} || max value -> {maxValue}");
