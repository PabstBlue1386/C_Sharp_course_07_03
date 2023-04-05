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

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" [{arr[i, j]}]");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void Average(int[,] arr)
{
    double aver = 0;


    for (int i = 0; i < arr.GetLength(1); i++)
    {


        aver = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            aver += arr[j, i];
        }
        aver = Math.Round(aver / arr.GetLength(0), 2);
        Console.Write($" [{aver}]");

    }

}


int[,] matrix = GenerateRandomArray();
PrintArray(matrix);

Average(matrix);




