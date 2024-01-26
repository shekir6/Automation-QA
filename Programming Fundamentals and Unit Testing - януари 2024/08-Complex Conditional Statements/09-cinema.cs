string movi = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

if  (movi == "Premiere")
{
    double totalPrice = rows * seats * 12.00;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (movi == "Normal")
{
    double totalPrice = rows * seats * 7.50;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (movi == "Discount")
{
    double totalPrice = rows * seats * 5.00;
    Console.WriteLine($"{totalPrice:F2}");
}