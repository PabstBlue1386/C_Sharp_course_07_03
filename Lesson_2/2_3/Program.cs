String Multiple(int num)
{
    if ((num % 7 == 0) && (num % 23 == 0 )) return $"Number {num} multiple 7 and 23";
    else return $"Number {num} not multiple 7 and 23";
}

int number = int.Parse(Console.ReadLine()!);
String result = Multiple(number);
Console.WriteLine(result);