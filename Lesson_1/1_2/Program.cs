Console.Write("Enter nuber 1-7: ");
int x = int.Parse(Console.ReadLine()!);

if (x == 1)
{
    Console.Write("Monday");
}
else if (x == 2)
{
    Console.Write("Tuesday");
}
else if (x == 3)
{
    Console.Write("Wednesday");
}
else if (x == 4)
{
    Console.Write("Thursday");
}
else if (x == 5)
{
    Console.Write("Friday");
}
else if (x == 6)
{
    Console.Write("Saturday");
}
else if (x == 7)
{
    Console.Write("Sunday");
}
else
{
    Console.Write("Number doesn't fit");
}