namespace Calc;

public class Calc
{
    public static void Main(string[] args)
    {
    }
    
    public double[] Roots(double a, double b, double c)
    {
        double discriminant = (b*b) - 4 * a * c;

        if (discriminant < 0)
            return [];
        if (discriminant == 0)
            return [-b / (2 * a)];
        double sqrtDiscriminant = Math.Sqrt(discriminant);
        double root1 = (-b + sqrtDiscriminant) / (2 * a);
        double root2 = (-b - sqrtDiscriminant) / (2 * a);
        return [root1, root2];
    }

    public double Percent(double x, double percent)
    {
        return (percent / 100) * x;
    }
}

