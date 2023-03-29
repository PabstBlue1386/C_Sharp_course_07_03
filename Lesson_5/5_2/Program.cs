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

String CheckDigit(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return $"Digit {num} present";
    }
    return $"Digit {num} not present";
}

int[] mass = GenerateRandomArray(sizeMass, downBorder, upBorder);
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
PrintArray(mass);
Console.WriteLine();
String result = CheckDigit(mass, number);
Console.WriteLine(result);