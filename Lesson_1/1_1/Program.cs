Console.Write("Enter first number: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Enter second numer: ");
int y = int.Parse(Console.ReadLine()!);
if(y * y == x)
{
    Console.Write(x + " Is square of this number " + y);  
}
else 
{
    Console.Write(x + " Is not the square of this number " + y);
}