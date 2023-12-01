using curvature;

const double radius = 6_378_000;

// prompt the section length in meters
Console.Write("Enter the section length in meters: ");
double sectionLength = double.Parse(Console.ReadLine() ?? string.Empty);

double difference = Calculator.CalculateDifference(sectionLength, radius);
Console.WriteLine($"Difference: {difference,10:F3} meters");

