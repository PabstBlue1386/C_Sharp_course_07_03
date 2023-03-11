//Задача 2: Напишите программу, которая принимает
//на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter third number: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.Write("First number is maximal");
    }
    else
    {
        Console.Write("Third number is maximal");
    }
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.Write("Second number is maximal");
    }
    else
    {
        Console.Write("Third number is maximal");
    }
}