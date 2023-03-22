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


int[] ProductPairs(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] resultArr = new int[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            resultArr[i] = arr[i] * arr[arr.Length - i - 1];
        }
        return resultArr;
    }
    else
    {
        int[] resultArr = new int[arr.Length / 2 +1];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            resultArr[i] = arr[i] * arr[arr.Length - i - 1];
        }
        resultArr[resultArr.Length -1] = arr[arr.Length /2];
        return resultArr;
    }

}

int[] array = GenerateRandomArray(sizeMass, downBorder, upBorder);
int[] result = ProductPairs(array);
PrintArray(array);
Console.WriteLine();
PrintArray(result);