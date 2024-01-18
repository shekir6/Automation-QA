double distance = distance.Parse(Console.ReadLine());
double time = time.Parse(Console.ReadLine());

double speed = distance / time;

Console.WriteLine($"{speed:F2}");
