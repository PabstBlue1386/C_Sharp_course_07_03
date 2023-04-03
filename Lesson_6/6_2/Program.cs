string Binary(int digit)
{
    string stringBin = "";

    while (digit >= 1)
    {
        stringBin = digit%2 + stringBin;
        digit /= 2;

    }
    return stringBin;
}


Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine()!);
string bin = Binary(a);
Console.Write(bin);

