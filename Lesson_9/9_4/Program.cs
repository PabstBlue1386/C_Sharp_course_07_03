int Exponentiation(int a, int b)
{
    if(b>0) return Exponentiation(a,b-1)*a;
    else return 1;
}
Console.Write("Enter number A: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Exponentiation {num}^{num2} -> {Exponentiation(num,num2)}");