int Sum (int a, int b)
{
    if (a<b) return Sum(a+1,b) + a;
    return a; 
}
Console.Write("Enter number A: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write($"sum -> {Sum(num,num2)}");
