void Multiple(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 % num2 == 0) 
            {
                Console.WriteLine($"Number {num2} multiple number {num1} ");
            }
            else Console.WriteLine($"Number {num2} not multiple, reminder {num1 % num2}");
    }
    else Console.WriteLine($"Number {num1} greater {num2}");
}

int firstNum = int.Parse(Console.ReadLine()!);
int secNum = int.Parse(Console.ReadLine()!);
Multiple(firstNum, secNum);