int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

int powerNum = 1;

for (int i = 0; i < p; i++)
{
    powerNum *= n;
}

Console.WriteLine(powerNum);