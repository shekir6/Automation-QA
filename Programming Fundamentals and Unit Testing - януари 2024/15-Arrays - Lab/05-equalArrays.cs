int[] number1 = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
int[] number2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isidentical = true;

for (int i = 0; i < number1.Length; i++)
{
    if (number1[i] != number2[i])
    {
        isidentical = false;
        break;
    }
}

if (isidentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}