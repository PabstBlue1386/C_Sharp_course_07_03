int Factorial(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        product *= i;
    }
    return product;
}


Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int productNumber = Factorial(number);
Console.Write(productNumber);
