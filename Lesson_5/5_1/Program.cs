﻿int[] GenerateRandomArray(int size, int from, int to)
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

int[] InvertMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

int[] mass = GenerateRandomArray(sizeMass, downBorder, upBorder);
PrintArray(mass);
Console.WriteLine();
PrintArray(InvertMass(mass));




