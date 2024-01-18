int numOfPages = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int numOfDays = int.Parse(Console.ReadLine());

int totalReadingTime = numOfPages / pages;
int hourPerDay = totalReadingTime / numOfDays;

Console.WriteLine(hourPerDay);