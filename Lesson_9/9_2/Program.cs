Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine()!);

NaturalDigit(m,n);

void NaturalDigit(int min, int max)
{
    if (min-1 == max) return;
    NaturalDigit(min, max-1 );
    Console.Write($" {max} ");
}
