﻿int[,] GenerateRandomArray()
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

String FindElement(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                return $"Element {element} located [{i}, {j}]";
            }
        }

    }
    return $"Element {element} not found";
}

int[,] matrix = GenerateRandomArray();
PrintArray(matrix);
Console.Write("Enter find element: ");
int a = int.Parse(Console.ReadLine()!);
String result = FindElement(matrix, a);
Console.Write(result);


