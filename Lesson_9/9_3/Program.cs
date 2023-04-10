int Sum(int a) 
{
    if (a<10) return a;
    return Sum(a/10) + a %10;
}
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum -> {Sum(num)}");