    Console.Write("Enter number rows: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter number columns: ");
    int columns = int.Parse(Console.ReadLine()!);
    Console.Write("Enter down border mass: ");
    int downBorder = int.Parse(Console.ReadLine()!);
    Console.Write("Enter up border mass: ");
    int upBorder = int.Parse(Console.ReadLine()!);

int[,] GenerateRandomArray(int rows, int columns, int downBorder, int upBorder)
{
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

int[] CountDigit(int [,] array, int upBorder)
{
    int[] resultArray= new int [upBorder+1];
    foreach (var item in array)
    {
        resultArray[item]++;
    }
    return resultArray;
}

void PrintSingleArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" {i} -> {array[i]}");
    }
}

int[,] matrix = GenerateRandomArray(rows,columns,downBorder,upBorder);
PrintArray(matrix);

int[] resultArray = CountDigit(matrix,upBorder);
PrintSingleArray(resultArray);

