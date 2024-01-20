int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double priceChickenMenu = chickenMenu * 10.35;
double pricefishMenu = fishMenu * 12.40;
double pricevegetarianMenu = vegetarianMenu * 8.15;

double totalCostMenu = priceChickenMenu + pricefishMenu + pricevegetarianMenu;
double priceOfDessert = totalCostMenu * 0.20;
double delevryPrice = 2.50;

double totalOrderPrice = totalCostMenu + priceOfDessert + delevryPrice;

Console.WriteLine(totalOrderPrice);