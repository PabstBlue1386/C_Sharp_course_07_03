int[,] GenerateRandomArray()
{
    Console.Write("Enter number rows: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter number columns: ");
    int columns = int.Parse(Console.ReadLine()!);
    Console.Write("Enter down border mass: ");
    int downBorder = int.Parse(Console.ReadLine()!);
    Console.Write("Enter up border mass: ");
    int upBorder = int.Parse(Console.ReadLine()!);
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(downBorder, upBorder + 1);
        }
    }

    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" [{array[i, j]}]");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int[] FindMin(int[,] arr)
{
    int minEl = arr[0, 0];
    int[] cordMinElem = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minEl > arr[i, j])
            {
                minEl = arr[i, j];
                cordMinElem[0] = i;
                cordMinElem[1] = j;

            }
        }
    }
    return cordMinElem;
}

void ExtractCord(int[,] arr, int[] cord)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == cord[0] || j == cord[1]) continue;
            Console.Write($" [{arr[i, j]}]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GenerateRandomArray();
PrintArray(matrix);

int[] cordinates = FindMin(matrix);
ExtractCord(matrix, cordinates);