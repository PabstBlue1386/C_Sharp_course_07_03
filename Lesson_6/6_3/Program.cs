/*int[] Numbers(int digit)
{
    int[] result = new int[digit];
    (result[0], result[1]) = (0, 1);
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {   
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
    Console.WriteLine();
}

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = Numbers(num);
PrintArray(array);

*/

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
void Fibonacci (int  num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a+b);
    }
}

Fibonacci(num);