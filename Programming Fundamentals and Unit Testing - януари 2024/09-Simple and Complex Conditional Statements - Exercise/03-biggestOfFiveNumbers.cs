int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine()); 

int[] numbers = { num1, num2, num3, num4, num5 };
int biggestNumber = numbers.Max();
Console.WriteLine(biggestNumber);
