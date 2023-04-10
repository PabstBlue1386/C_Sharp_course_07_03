void NatNum(int a, int b)
{
    if (a <= b)
    {
        if (a % 2 == 0)
        {
            Console.Write($" {a}");
        }
        NatNum(a + 1, b);
    }
}

Console.Write("Enter number A: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int num2 = int.Parse(Console.ReadLine()!);
NatNum(num,num2);
