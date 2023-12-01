namespace curvature;

public static class Calculator
{
    public static double CalculateDifference(double sectionLength, double radius)
    {
        double quarterCurvature = 2 * radius * Math.PI / 4;
        double angle = sectionLength / quarterCurvature * 90;
        double leg = Math.Cos(angle * Math.PI / 180) * radius;
        double difference = radius - leg;
        return difference;
    }
}
