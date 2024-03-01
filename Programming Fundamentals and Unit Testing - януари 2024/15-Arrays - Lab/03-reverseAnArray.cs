int size = int.Parse(Console.ReadLine());

int[] number = new int[size];

for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
}

for (int i = number.Length - 1; i >= 0 ; i--)
{
    Console.Write($"{number[i]} ");
}