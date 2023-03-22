int[] GenerateRandomArray()
{
    Console.Write("Enter size mass: ");
    int sizeMass = int.Parse(Console.ReadLine()!);
    Console.Write("Enter down border mass: ");
    int downBorder = int.Parse(Console.ReadLine()!);
    Console.Write("Enter up border mass: ");
    int upBorder = int.Parse(Console.ReadLine()!);
    int[] arr = new int[sizeMass];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(downBorder, upBorder + 1);
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
    Console.WriteLine();
}

int CountEven(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2 == 0) 
        count++;
    }
    return count;
}

int [] result = GenerateRandomArray();
PrintArray(result);
int counter = CountEven(result);
Console.WriteLine($"Even: {counter}");

