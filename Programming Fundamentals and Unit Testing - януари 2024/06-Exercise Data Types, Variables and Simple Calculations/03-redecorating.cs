int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int quantityOfThinner  = int.Parse(Console.ReadLine());
int HoursWork  = int.Parse(Console.ReadLine());

double amountNylon = (nylon + 2) * 1.50;
double amounPaint = (paint * 1.1) * 14.5;
int amountTiner = quantityOfThinner * 5;
double bags = 0.4;

double totalAmountMaterials = amountNylon + amounPaint + amountTiner + bags;
double amountCraftMan = totalAmountMaterials * 0.3;
double craftsmanTotalSalary = amountCraftMan * HoursWork;

double totalPrice = totalAmountMaterials + craftsmanTotalSalary;


Console.WriteLine(totalPrice);