void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.Write($" {Math.Pow(index, 3)}, ");
        index++;
    }
}

Console.Write("Enter number N: ");
int number = int.Parse(Console.ReadLine()!);

Cube(number);
