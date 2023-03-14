void Weekend(int day)
{
    if (day < 1 || day > 7) Console.WriteLine("Not a day of the week");
    else if (day == 6 || day == 7) Console.WriteLine("Today is Weekend!");
    else Console.WriteLine("Today is weekday");
}

Console.Write("Enter the number of the day of the week: ");
int numDay = int.Parse(Console.ReadLine()!);
Weekend(numDay);