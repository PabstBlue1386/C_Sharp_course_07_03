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
//TODO Допилить произведение пар чисел массива и вывести новый массив
int [] ProductPairs(int[] arr)
{
    int [] resultArr = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        for (int j = arr.Length; i>  )
    }
}