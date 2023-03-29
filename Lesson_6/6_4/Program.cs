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

int [] CopyArray(int[] arr)
{
    int size = arr.Length;
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int[] firstArr = GenerateRandomArray();
PrintArray(firstArr);
int[] secArr = CopyArray(firstArr);
PrintArray(secArr);