int Amount(int number)
{
    int a = 0;
    if (number < 0) number *= -1;
    for (int i = 0; number > 0; i++)
    {
        a++;
        number /= 10;
    }
    return a;
}


Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
int amount = Amount(num);
Console.Write(amount);
