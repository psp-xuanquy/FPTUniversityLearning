using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
		private string _id;     //biến lưu giá trị, nhưng phải gọi chính xác: instance variable; attribute, state,member,backing field,field (trường, vùng) dữ liệu 
        // dùng để lưu trữ thông tin của mỗi object phía hậu trường ,phía sâu của object mà đứng bên ngoài ko thấy. Đứng trước mặt bạn, tôi không biết quê, tên, tuổi....của bạn, ví đó private
        private string _name;
    
		public string Id       //property,kỹ thuật viết get set gọn hơn, nhưng bản chất sau lưng hậu trường vẫn là xài backing field như bth. Kĩ thuật này gọi tên là Full property - viết đầy đủ mọi thứ 
            // gõ propfull tab tab để có đc khai báo 
            //property public _id
            //ra ngoài qua get set
            // muốn sài Get: tên biến mà xai
            // .Id  cw(.Id)
            //muốn sài  Set: tên biến = value đưa vào 
            // .Id = "SE12345" set gái trị cho biến ngầm phía sau Id
            //Giúp nhìn Object tự nhiên hơn so gọi hàm get set 
            // nhờ cách này ta có thêm 1 cách NEW nữa , NEW OBJECT STYLE mới 
		{
			get => _id; 
			set => _id = value; 
		}
        // mẹo gõ propfull + Tab : ra get set và click 2 lần chỗ value 

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _yob;
        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }


    }
}
