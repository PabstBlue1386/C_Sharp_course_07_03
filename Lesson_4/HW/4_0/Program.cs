int Degree(int numA, int numB)
{
    int tempNumA = 1;
    for (int i = 0; i < numB; i++)
    {
        tempNumA *= numA;
    }
    return tempNumA;
}



Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int b = int.Parse(Console.ReadLine()!);
int result = Degree(a, b);

Console.WriteLine(result);
