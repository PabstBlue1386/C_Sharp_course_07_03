int[] GenerateRandomArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
}

Console.Write("Enter size mass: ");
int sizeMass = int.Parse(Console.ReadLine()!);
Console.Write("Enter down border mass: ");
int downBorder = int.Parse(Console.ReadLine()!);
Console.Write("Enter up border mass: ");
int upBorder = int.Parse(Console.ReadLine()!);

int Counter(int [] arr, int from, int to)
{
    int count = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i] >= from && arr[i] <= to)
        count++;
    }
    return count;
}

int [] mass = GenerateRandomArray(sizeMass, downBorder, upBorder);
Console.Write("Enter down value: ");
int downValue  = int.Parse(Console.ReadLine()!);
Console.Write("Enter up value: ");
int upValue = int.Parse(Console.ReadLine()!);
PrintArray(mass);
Console.WriteLine();
int result = Counter(mass, downValue, upValue);
Console.WriteLine(result);