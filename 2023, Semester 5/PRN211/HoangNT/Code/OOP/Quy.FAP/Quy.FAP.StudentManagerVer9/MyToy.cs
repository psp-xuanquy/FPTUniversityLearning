using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer9
{
    /// <summary>
    /// Chứa các hàm là công cụ xử lý dùng chung cho các class khác
    /// Vì là đồ dùng chung nên nó sẽ là static, xài trực tiếp mà ko cần new
    /// Muốn new static thì cũng chỉ có 1 vùng ram chứa static mà thôi
    /// </summary>
    internal class MyToy
    {
        /// <summary>
        /// Hàm này sẽ tính n! = 1.2.3...n; trong đó 0! = 1! = 1
        /// ko có giai thừa của số âm
        /// Hàm này tính tối đa 20!, vì 21! tràn kiểu long
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
       public static long ComputerFactorial(int n)
        {
            
            if (n < 0 || n > 20)
            {
                throw new ArgumentOutOfRangeException("n must be [0; 20]");
            } 
            if (n == 0 || n == 1)
            {
                return 1;
            }
            //For kiểu truyền thống
            //long ans = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    ans *= i;   //i cứ tăng thì cứ nhân vs i dần vào biến ans
            //}
            //return ans;

            //Tính kiểu đệ quy
            return n * ComputerFactorial(n - 1);

        }
    }
}
