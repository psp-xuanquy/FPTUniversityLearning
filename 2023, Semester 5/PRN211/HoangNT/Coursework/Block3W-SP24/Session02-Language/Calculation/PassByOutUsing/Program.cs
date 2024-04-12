namespace PassByOutUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt(25);

            //1 2 3 4 5 6 7 8 9 10
            //         55    5e    25o
            // 
            int sumAll = PlayWithNumbers(out int sumO, out int countE);
            Console.WriteLine($"Sum all {sumAll} | sum odds {sumO} | count evens {countE}");
            // 55 25 5
        }

        // OUT, IN, REF
        //TODO: PassByIn( in Student x) x sẽ đc hiểu là readonly ra  sao !!!
        static void PassByIn(in int x)
        {
            // x = 100;
            // x ko cho thay đổi value sang giá trị khác
            // dùng x trong các biểu thức tính toán thì oki
            // readonly parameter
        }

        //Challenge: viết cho tui hàm tính toán trên dãy số từ 1...100
        //Từ 1...100 có bao nhiêu số chẵn
        //Từ 1...100 tổng các con số lẻ là bao nhiêu
        //Từ 1...100 đếm xem có bao nhiêu số nguyên tố
        //Từ 1...100 tính tổng của all
        //YÊU CẦU: TRẢ VỀ GIÁ TRỊ ĐỂ XÀI, KO IN RA TRONG HÀM
        //GIỐNG SQRT() VÀ CHỈ DÙNG 1 HÀM DUY NHẤT!!!

        static int PlayWithNumbers(out int sumOdds, out int countEvens)
        {
            sumOdds = 0;
            countEvens = 0;
            int sumAll = 0;//khởi đầu tất cả bằng 0, tùy cơ ứng biến tăng giá trị 
            for (int i = 1; i <= 10; i++)
            {
                //sumAll = sumAll + i;
                sumAll += i;
                if (i % 2 == 0)
                    countEvens++;
                else
                    sumOdds += i;

            }

            return sumAll;
        }

    }
}
