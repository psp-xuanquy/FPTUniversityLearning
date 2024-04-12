namespace BmiV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = GetBmi(55, 1.6);
            Console.WriteLine($"Your BMI: {bmi}");
        }

        // Triết lí thiết kế hàm: nhận vào --> xử lí --> trả ra
        static double GetBmi(double weight, double height)
        {
            //return weight / (height * height);
            return weight / Math.Pow(height, 2);
        }
    }
}
