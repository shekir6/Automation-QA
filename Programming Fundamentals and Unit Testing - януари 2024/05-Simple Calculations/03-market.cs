double tomatosPrice = double.Parse(Console.ReadLine());
double tomatosQuantitye = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantitye = double.Parse(Console.ReadLine());

double Tomatoes = tomatosPrice * tomatosQuantitye;
double Cucumbers = cucumberPrice * cucumberQuantitye;

double totalCoast = Tomatoes + Cucumbers;

Console.WriteLine($"{totalCoast:F2}");