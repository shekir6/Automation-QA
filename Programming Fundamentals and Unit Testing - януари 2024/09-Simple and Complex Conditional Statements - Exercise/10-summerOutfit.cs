using System.Text.Unicode;

int degrees = int.Parse(Console.ReadLine());
string timeOfDate = Console.ReadLine();

string outfit = "";
string shoes = "";


if (degrees >=10 && degrees <= 18)
{
    if(timeOfDate == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (timeOfDate == "Afternoon" || timeOfDate == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";

    }
}
else if (degrees >= 18 && degrees <= 24)
{
    if (timeOfDate == "Morning")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (timeOfDate == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";

    }
    else if (timeOfDate == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (degrees >= 25)
{
    if (timeOfDate == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfDate == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (timeOfDate == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");