int Sum(int num)
{
    int sum_all = 0;
    for (int i = 1; i<=num; i++) sum_all += i;
    return sum_all;
}

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int result = Sum(number);
Console.WriteLine(result);

