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


int[] CoupMass(int [] array)
{
    int [] resultArray = new int [array.Length];
    for (int i = 0; i< array.Length;i++)
    {
        resultArray[i] = array[array.Length-i-1];
    }
    return resultArray;
    
}

int[] array = GenerateRandomArray();
PrintArray(array);
int[] newArray = CoupMass(array);
PrintArray(newArray);