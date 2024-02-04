int n = int.Parse(Console.ReadLine());

int sum = 0;

while (n != 0)
{
    int digits = n % 10;
    n = n / 10;
    sum += digits;  

}
Console.WriteLine(sum);