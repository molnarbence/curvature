const double radius = 6_378_000;
// get section length from input parameter
double sectionLength = double.Parse(args[0]);

// write the result to the console
var curvature = CalculateCurvature(sectionLength, radius);
// write in meters with 2 decimal places and some padding
Console.WriteLine($"Radius: {radius / 1000,16:F2} km");
Console.WriteLine($"Section length: {sectionLength / 1000,8:F2} km");
// add a line of dashes
Console.WriteLine(new string('-', 40));
Console.WriteLine($"Curvature {curvature,14:F2} m");

static double CalculateCurvature(double sectionLength, double radius)
{
    double quarterCurvature = 2 * radius * Math.PI / 4;
    double angle = sectionLength / quarterCurvature * 90;
    double leg = Math.Cos(angle * Math.PI / 180) * radius;
    double difference = radius - leg;
    return difference;
}