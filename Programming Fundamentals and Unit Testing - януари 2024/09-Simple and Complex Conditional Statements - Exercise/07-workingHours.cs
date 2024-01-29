
int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

switch (dayOfTheWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":    
        if (hourOfTheDay >= 10 && hourOfTheDay <=18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Sunday":
        Console.WriteLine("closed");
        break;
}

//another solution

int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if (hourOfTheDay >= 10 && hourOfTheDay <= 18 && dayOfTheWeek != "Sunday")
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}