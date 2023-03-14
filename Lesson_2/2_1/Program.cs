void MaxNum(int num)
{
    int x = num % 10;
    int y = num / 10;
    if (x>y) Console.WriteLine(x);
    else Console.WriteLine(y);
}

int number = new Random().Next(10, 100);
Console.WriteLine(number);
MaxNum(number);