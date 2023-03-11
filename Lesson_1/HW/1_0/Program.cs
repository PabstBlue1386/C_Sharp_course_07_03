//  Задача 1: Напишите программу, которая на вход
//  принимает два числа и выдаёт, какое число
//  большее, а какое меньшее.

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber > secondNumber)
{
    Console.WriteLine("The first number is greater than the second");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("The second number is greater than the first");
}
else
{
    Console.WriteLine("The numbers are equal");
}