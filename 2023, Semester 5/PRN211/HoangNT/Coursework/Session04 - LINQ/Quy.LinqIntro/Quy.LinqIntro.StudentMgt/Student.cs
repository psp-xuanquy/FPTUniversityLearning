using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.LinqIntro.StudentMgt
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public void ShowProfile()
        {
            Console.WriteLine($"{Id} | {Name} | {Yob} | {Gpa}");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine("Hi all, this message comes from a traditional SayHello() method");
            Console.WriteLine(msg);
        }

        public void DoSomethingInFuture (Action f)
        {
            //Hàm DoSomethingInFuture() muốn chạy thì phải truyền vào 1 Delegate
            //tức là phải truyền vào cho nó 1 hàm void f() ở đâu đó
            //Ta đưa 1 hàm vào trong hàm này, kĩ thuật truyền hàm vào hàm, coi hàm là 1 tham số, 1 DataType - Functional Programming
            //Hàm đưa vào hàm, còn đc gọi là đưa 1 phụ thuộc, 1 tính toán, 1 xử lí logic bên ngoài vào hàm này - Dependency Injection (DI)
            //DI sẽ giúp mở rộng khả năng hành động của 1 class,
            //linh hoạt với các xử lí sẽ đến từ tương lai,
            //ai xài sau nỳ cứ đưa vào theo cách của họ
            //Cứ đưa action() của m vào, t gọi cho - Call-back
            f();   //T gọi hàm bên ngoài của m đưa về
                        //bên ngoài m làm gì cũng đc
        }
    }
}
