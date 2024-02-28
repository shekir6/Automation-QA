int n = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(GetMultipleOfEvenAndOdds(n));

static int GetSumOfEvenDigits(int number)
{
    int evenSum = 0;

    while (number > 0)
    {
        int digits = number % 10;  
        number /= 10;
        if (digits % 2 == 0)
        {
            evenSum += digits;  
        }
    }
    return evenSum;
}


static int GetSumOfOddDigits(int number)
{
    int oddSum = 0;

    while (number > 0)
    {
        int digits = number % 10;
        number /= 10;
        if (digits % 2 != 0)
        {
            oddSum += digits;
        }
    }
    return oddSum;
}


static int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}
    