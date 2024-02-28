int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}


for (int i = N - 1; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

