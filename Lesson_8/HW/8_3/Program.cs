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

bool CheckConformity(int[,] mat1, int[,] mat2)
{
    if (mat1.GetLength(1) == mat2.GetLength(0) && mat1.GetLength(1) == mat2.GetLength(1)) return true;
    else return false;
}

int[,] ProductMatrix(int[,] mat1, int[,] mat2)
{
    int columnsMat1 = mat1.GetLength(0);
    int rowsMat1 = mat1.GetLength(1);
    int columnsMat2 = mat2.GetLength(0);
    int rowsMat2 = mat2.GetLength(1);
    int[,] resultArr = new int[rowsMat1, columnsMat2];


    for (int i = 0; i < rowsMat1; i++)
    {
        for (int j = 0; j < columnsMat2; j++)
        {
            for (int n = 0; n < columnsMat1; n++)
            {
                resultArr[i, j] += mat1[i, n] * mat2[n, j];
            }
        }
    }

    return resultArr;
}

int[,] matrix = GenerateRandomArray();
PrintArray(matrix);
int[,] matrix2 = GenerateRandomArray();
PrintArray(matrix2);


if (CheckConformity(matrix, matrix2) == true)
{
    int[,] res = ProductMatrix(matrix, matrix2);
    PrintArray(res);
}
else
{
    Console.Write("Matrices are different");
}