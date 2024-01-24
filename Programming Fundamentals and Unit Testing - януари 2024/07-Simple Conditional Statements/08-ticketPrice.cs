string ticetType = Console.ReadLine();

if (ticetType == "student")
{
    Console.WriteLine("$1.00");
}
else if (ticetType == "regular")
{
    Console.WriteLine("$1.60");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}