// Задача 3: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).


Console.Write("Enter number: ");
double number = double.Parse(Console.ReadLine()!);
if (number % 2 == 0) Console.WriteLine("Number is even");
else Console.WriteLine("Number is not even");

