Console.Write("Enter number: ");
int x = int.Parse(Console.ReadLine()!);
if (x > 0)
{
    for (int i = x - x * 2; i <= x; i++)
    {
        Console.Write(" " + i);
    }
}
else if (x < 0)
{
    for (int i = x * -1; i >= x; i--)
    {
        Console.Write(" " + i);
    }
}
else Console.Write("Number doesn't fit");