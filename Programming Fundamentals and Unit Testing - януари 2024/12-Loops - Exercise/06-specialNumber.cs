//input
int number = int.Parse(Console.ReadLine());

//Act
int tempNumber = number;
bool isSpecialNumber = true;
while(tempNumber > 0)
{
    int currentLastDigits = tempNumber % 10; // take last digits
    tempNumber = tempNumber / 10; //Remove last digits

    if(number % currentLastDigits != 0)
    {
        isSpecialNumber = false; 
        break;
    }
}

//Output
if (isSpecialNumber)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}
