Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine()!);
NaturalDigitN(n);
void NaturalDigitN(int n)
{
    if (n==0) return;
    
    NaturalDigitN(n-1);
    Console.Write($" {n} ");
    
}
