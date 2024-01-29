double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string matOperation = Console.ReadLine();

if (matOperation == "+")
{
    double result = num1 + num2;
    Console.WriteLine($"{num1} {matOperation} {num2} = {result:F2}");
}
else if (matOperation == "-")
{
    double result = num1 - num2;
    Console.WriteLine($"{num1} {matOperation} {num2} = {result:F2}");
}
else if (matOperation == "*")
{
    double result = num1 * num2;
    Console.WriteLine($"{num1} {matOperation} {num2} = {result:F2}");
}
else if (matOperation == "/")
{
    double result = num1 / num2;
    Console.WriteLine($"{num1} {matOperation} {num2} = {result:F2}");
}