//input
int stopNumber = int.Parse(Console.ReadLine());




//Act
for (int numbers = 0; numbers != stopNumber; )
{
    int current = numbers;
    numbers = int.Parse(Console.ReadLine());
    




    if (numbers == stopNumber)
    {
        Console.WriteLine((current * 0.20) + current);
    }


}


//Output