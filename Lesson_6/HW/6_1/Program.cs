int CounterPositiveDigits(int num)
{
    int count =0;
    int temp;
    for(int i = 1; i<=num;i++)
    {
        Console.Write($"Num {i}: ");
        temp =  int.Parse(Console.ReadLine()!);
        if(temp > 0) count++;
    }
    return count;
}

Console.Write("How many numbers do you want to enter?: ");
int number = int.Parse(Console.ReadLine()!);
int result = CounterPositiveDigits(number);
Console.Write($"Number of positive numbers: {result}");