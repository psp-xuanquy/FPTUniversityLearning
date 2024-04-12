using BmiLibrary;

namespace BmiV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(55, 1.6);
            Console.WriteLine($"BMI: {bmi}");
        }
    }
}
