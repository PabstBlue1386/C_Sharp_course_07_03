int SumDigit(int num)
{
    int tempNum = 0;
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        tempNum =num;
        sum = sum + (tempNum % 10);
        num = num /10;
    }
    return sum;
}


Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int result = SumDigit(number);
Console.Write(result);
