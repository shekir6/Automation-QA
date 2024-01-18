double depositAmout = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double anual = double.Parse(Console.ReadLine());

double accumulatedInterest = depositAmout * (anual / 100);
double interestForOneMmonth = accumulatedInterest / 12;
double totalAmount = depositAmout + ( term * interestForOneMmonth);

Console.WriteLine(totalAmount);