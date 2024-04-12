namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Healthy Program");
            Console.WriteLine("This program will compute your BMI indicator");

            double weight = 55.0; // kg
            double height = 1.60; // m

            double bmi = weight / (height * height);

            Console.WriteLine("Your BMI based on your weight (" + weight + " kg) and height (" + height + " m) is: " + bmi);

            Console.WriteLine("Your BMI based on your weight ({0} kg) and height ({1} m) is: {2}", weight, height, bmi);    // Placeholder

            Console.WriteLine($"Your BMI based on your weight ({weight} kg) and height ({height} m) is: {bmi}");            // Interpolation

            Console.WriteLine("Nắng của trời, tiếng của người\r\nGần bên nhau làm em thấy vui\r\nMuốn theo chân người đi khắp nơi\r\n(Từ khi anh tới, lòng thấy vui lên)\n");

            Console.WriteLine(@"Nắng của trời, tiếng của người
Gần bên nhau làm em thấy vui
Muốn theo chân người đi khắp nơi
(Từ khi anh tới, lòng thấy vui lên)

Đối với đầu, ngả với nghiêng
Thật nhiều điều làm anh phát điên
Muốn tha anh về đây để làm của riêng (muốn tha anh về đây để làm của riêng)
Và cho anh thấy miền đất hứa kia (yah, yah)

");         // @: Verbatim String - raw string, chuỗi nguyên bản, có gì in nấy
            // dùng khi cần lưu đường dẫn tên tập tin

            string path = @"D:\new\csharp";
        }
    }
}
