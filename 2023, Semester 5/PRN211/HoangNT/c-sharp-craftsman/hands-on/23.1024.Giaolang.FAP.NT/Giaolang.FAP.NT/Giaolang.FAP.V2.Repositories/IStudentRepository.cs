using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.FAP.V2.Repositories
{
    public interface IStudentRepository //CLB ĐƯA RA TIÊU CHÍ NÓI CHUNG
                                        //ĐỂ ANH EM TỰ IMPLEMENT
    {
        //định nghĩa, đặt ra cuộc chơi yêu cầu anh em nếu muốn chơi thì
        //phải tuân thủ - tức là phải có những hàm đã khai báo ở đây
        //phải viết code cho những hàm ở đây, ko care code như thế nào
        //chỉ cần tuân thủ tên hàm
        //CHỨA HÀM KO CODE - ABSTRACT METHOD
        //INTEFACE VẪN CHO PHÉP HÀM CÓ CODE! NHƯNG...

        public List<Student> GetAll();
        public void Add(Student student);
        public void Update(Student student);
        public void Delete(string id);
        public List<Student> Search(string keyword);


    }
}
