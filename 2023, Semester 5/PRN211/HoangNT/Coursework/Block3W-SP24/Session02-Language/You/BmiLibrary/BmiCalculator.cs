namespace BmiLibrary
{
    /// <summary>
    /// Class này sẽ cung cấp các chỉ số để tính BMI của mỗi cá nhân
    /// This class offers method to calculate and evaluate personals' BMI indicator
    /// </summary>
    public class BmiCalculator
    {
        //Ta thiết kế ckass này như là class tiện ịch, cung cấp dịch vụ dùng chung
        // do đó desgin dùng STATIC

        /// <summary>
        /// Hàm này sẽ tính ra chỉ số BMI dựa trên chiều cao và cân nặng của 1 người
        /// This method will calculate BMI indicator based on personal's weight & height
        /// </summary>
        /// <param name="weight">Cân nặng tính bằng kg</param>
        /// <param name="height">Chiều cao tính bằng m</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / Math.Pow(height, 2); // Expression body -> Viết rút gọn thân hàm

        //public static double GetBmi(double weight, double height)
        //{
        //    return weight / Math.Pow(height, 2);
        //}
    }


}
