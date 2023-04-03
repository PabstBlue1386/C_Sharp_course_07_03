void CheckTriangle(int sideA, int sideB, int sideC)
{
    if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
    {
        Console.WriteLine($"Triangle with sides {sideA}, {sideB} and {sideC} can exist");
    }
    else
    {
        Console.WriteLine($"Triangle with sides {sideA}, {sideB} and {sideC} cannot exist");
    }
}

int a, b, c;
Console.Write("Enter first side: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Enter second side: ");
b = int.Parse(Console.ReadLine()!);
Console.Write("Enter third side: ");
c = int.Parse(Console.ReadLine()!);

CheckTriangle(a, b, c);

