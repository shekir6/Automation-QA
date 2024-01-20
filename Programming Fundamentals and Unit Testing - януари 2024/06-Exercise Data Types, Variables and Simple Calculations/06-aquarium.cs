int length = int.Parse(Console.ReadLine()); 
int width = int.Parse(Console.ReadLine()); 
int height  = int.Parse(Console.ReadLine()); 
double percentage  = int.Parse(Console.ReadLine());

double volumeAquarium = length * width * height;
double volumeLiters = volumeAquarium * 0.001;
double occupiedSpace = percentage / 100;
double requiredLiters = volumeLiters * (1 - occupiedSpace);


Console.WriteLine($"{requiredLiters:F2}");