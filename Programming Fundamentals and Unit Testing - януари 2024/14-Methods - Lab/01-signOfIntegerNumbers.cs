﻿int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"The number {number} is positive.");
}
else if (number < 0)
{
    Console.WriteLine($"The number {number} is negative.");
}
else if(number == 0)
{
    Console.WriteLine($"The number {number} is zero.");
}