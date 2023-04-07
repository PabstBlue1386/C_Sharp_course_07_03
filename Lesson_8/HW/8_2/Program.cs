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

int[] SumDigitRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] sumDigit = new int[array.GetLength(0)];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumDigit[i] = sumDigit[i] + array[i, j];
        }
    }
    return sumDigit;
}

void PrintSingleArray(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i]; 
            indexMin=i;
        }
        
    }
    Console.WriteLine($"The minimum value of the amount --> {min} in the line --> {indexMin+1}");
}



int[,] matrix = GenerateRandomArray();
PrintArray(matrix);

int[] resArr = SumDigitRows(matrix);
PrintSingleArray(resArr);


