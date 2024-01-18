string architecturesName = Console.ReadLine();
int numOfProject = int.Parse(Console.ReadLine());

int hourCount = numOfProject * 3;

Console.WriteLine($"The architect {architecturesName} will need {hourCount} hours to complete {numOfProject} project/s.");