double balance = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
        break;

    double amount = double.Parse   (input);
    balance += amount;

    if (amount >= 0)
        Console.WriteLine("Increase: {0:F2}", amount);
    else
        Console.WriteLine("Decrease: {0:F2}", Math.Abs(amount));
}

Console.WriteLine("Balance: {0:F2}", balance);