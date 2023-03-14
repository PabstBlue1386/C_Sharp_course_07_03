void ThirdNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("No third digit");
    }
    else
    {
        while (num > 999) num /= 10;               
        num %= 10;
        Console.WriteLine($"Third digit is {num}");
        }
}

Console.Write("Enter any number: ");
int anyNumber = int.Parse(Console.ReadLine()!);
ThirdNum(anyNumber);