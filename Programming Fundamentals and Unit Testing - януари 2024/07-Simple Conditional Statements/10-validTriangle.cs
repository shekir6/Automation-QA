int sideOne = int.Parse(Console.ReadLine());
int sideTwo = int.Parse(Console.ReadLine());
int sideThree = int.Parse(Console.ReadLine());

if (sideOne >= sideTwo + sideThree)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideTwo >= sideOne + sideThree)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideThree >= sideOne + sideTwo)
{
    Console.WriteLine("Invalid Triangle");
}
else
{
    Console.WriteLine("Valid Triangle");
}



