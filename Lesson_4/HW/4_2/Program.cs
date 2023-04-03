int[] GenerateRandomArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
}

Console.Write("Enter size mass: ");
int sizeMass = int.Parse(Console.ReadLine()!);
Console.Write("Enter down border mass: ");
int downBord = int.Parse(Console.ReadLine()!);
Console.Write("Enter up border mass: ");
int upBord = int.Parse(Console.ReadLine()!);
WriteArray(GenerateRandomArray(sizeMass, downBord, upBord));
