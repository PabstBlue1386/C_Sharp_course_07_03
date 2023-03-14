void DellSecondNumber(int num)
{
    int firstNum = num / 100;
    int secondNum = num % 10;
    Console.Write(firstNum);
    Console.WriteLine(secondNum);
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
DellSecondNumber(number);