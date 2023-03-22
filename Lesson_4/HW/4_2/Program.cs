int[] GenerateRandomArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(10);
    return arr;
}

void WriteArray(int[] array)
{
    for (int i = 0; i< array.Length;i++)
    Console.Write(" " + array[i]);
}

WriteArray(GenerateRandomArray());
