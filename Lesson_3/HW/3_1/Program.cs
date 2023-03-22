double Distanse(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}


Console.Write("Enter x1 -> ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter y1 -> ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter z1 -> ");
double z1 = double.Parse(Console.ReadLine()!);


Console.Write("Enter x2 -> ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter y2 -> ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter z2 -> ");
double z2 = double.Parse(Console.ReadLine()!);


Console.Write($"The distance between points in space -> {Distanse(x1, x2, y1, y2, z1, z2)}");
