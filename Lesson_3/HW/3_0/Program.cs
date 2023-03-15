void Palindrome(int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 % 10;
    int digit3 = num % 100 / 10;
    int digit4 = num % 10;

    Console.WriteLine($"Digit 1 -> {digit1} Digit 2 -> {digit2} Digit 3 -> {digit3} Digit 4 -> {digit4}");
    if (num > 99999 || num < 10000) Console.WriteLine("Enter non-five digit number");
    else if (digit1 == digit4 && digit2 == digit3) Console.WriteLine($"{num} -> Palindrom number");
    else Console.WriteLine($"{num} -> Number not palindrome");
}

/*Boolean flag = false;
while (flag != true)
{
    if (Console.ReadLine() == "q") flag = true;
    else
    {
        Console.Write("Enter five-digit number: ");
        int number = int.Parse(Console.ReadLine()!);
        Palindrome(number);
    }


}*/
//Не придумал как реализовать цикличность до команды выхода из приложения)

Console.Write("Enter five-digit number: ");
int number = int.Parse(Console.ReadLine()!);
Palindrome(number);