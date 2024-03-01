int[] number1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] number2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < number1.Length; i++)
{
	for (int j = 0; j < number2.Length; j++)
	{
		if (number1[i] == number2[j])
		{
			Console.Write($"{number1[i]} ");
        }
	}
}
