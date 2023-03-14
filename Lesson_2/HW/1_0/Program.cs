void SecondNumber(int number)
{
    if (number > 100 && number < 999)
    {
        number = number / 10 % 10;
        Console.WriteLine(number);
    } 
    else 
    {
        Console.WriteLine("Number not three digits");
    }
}

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
SecondNumber(num);