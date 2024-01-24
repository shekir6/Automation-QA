string figure = Console.ReadLine();

if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double sum = side * side;
    Console.WriteLine($"{sum:F2}");
}
else if (figure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    double sum = width * length;
    Console.WriteLine($"{sum:F2}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double sum =Math.PI * radius * radius;
    Console.WriteLine($"{sum:F2}");
}