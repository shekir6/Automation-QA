﻿double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double adding = firstNumber + secondNumber;
double subtraction = firstNumber - secondNumber;
double multiplication = firstNumber * secondNumber;
double division = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {adding:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtraction:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplication:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {division:F2}");