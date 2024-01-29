int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int totalSeconds = num1 + num2 + num3;

int timeMinutes  = totalSeconds / 60;
int timeSecond = totalSeconds % 60;

Console.WriteLine($"{timeMinutes}:{timeSecond:D2}");