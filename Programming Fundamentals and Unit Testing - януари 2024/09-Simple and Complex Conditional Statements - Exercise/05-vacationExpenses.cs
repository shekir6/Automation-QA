string season = Console.ReadLine();
string accommodationType= Console.ReadLine();
int dayCount = int.Parse(Console.ReadLine());

double pricePerNight = 0;
double discount = 0;


if( season == "Spring")
{
    discount = 0.2; // 20%
    if (accommodationType == "Hotel")
    {
        pricePerNight = 30;
    }
    else if(accommodationType == "Camping")
    {
        pricePerNight = 10;
    }
}
else if( season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 50;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 30;
    }
}
else if( season == "Autumn")
{
    discount = 0.3; // 30%
    if (accommodationType == "Hotel")
    {
        pricePerNight = 20;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 15;
    }
}
else if( season == "Winter")
{
    discount = 0.1; // 10%
    if (accommodationType == "Hotel")
    {
        pricePerNight = 40;
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 10;
    }
}
double totalPriceNoDiscoun = dayCount * pricePerNight;
double totalPrice = totalPriceNoDiscoun - (totalPriceNoDiscoun * discount);

Console.WriteLine($"{totalPrice:F2}");


