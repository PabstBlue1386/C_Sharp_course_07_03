// Задача 4: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все
//чётные числа от 1 до N.

Console.Write("Enter nuber N: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    double j = i;
    if (j % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}
