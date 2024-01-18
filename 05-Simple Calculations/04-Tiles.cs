double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight;
double addSurplus = bathroomArea + (bathroomArea * 0.1);
double tileArea = tileWidth * tileHeight;
double tilesneeded = addSurplus / tileArea;

Console.WriteLine(Math.Round(tilesneeded));