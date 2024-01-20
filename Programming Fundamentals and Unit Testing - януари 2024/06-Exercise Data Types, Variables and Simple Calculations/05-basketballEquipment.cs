int anualFee = int.Parse(Console.ReadLine());

double priceSnikers = anualFee * 0.60;
double priceBascetteam = priceSnikers * 0.80;
double priceOfBascet = priceBascetteam / 4;
double priceBascetAccessories = priceOfBascet / 5;

double totalPrice = anualFee + priceSnikers + priceBascetteam + priceOfBascet + priceBascetAccessories;

Console.WriteLine(totalPrice);