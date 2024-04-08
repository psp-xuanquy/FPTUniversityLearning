using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Runner.DeathRacer
{
    internal interface Racer
    {
        //Là 1 dạng class CHA đặc biệt, chính là những clb
        //Clb có tiêu chí hoạt động, các member (class CON) tham gia vào thì phải hoạt động theo tiêu chí của clb
        //tiêu chí hoạt động của clb chính là các hàm
        //Để các thành viên chủ động sáng tạo thì các tiêu chí hoạt động sẽ là những abstract class để ae tự do triển khai
        //Clb đua thì tiêu chí hoạt động sẽ là RunToDeath(), và hoạt động này sẽ là abstract
        //run() sẽ tùy thuộc mỗi ng run()

        public abstract double RunToDeath();
    }
}
