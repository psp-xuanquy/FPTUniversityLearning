using StudentManager.Entities;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithPrimitiveArray();
            PlayWithStudentList();
        }

        //CLASS -> GIÚP TẠO RA CÁC OBJECT
        //MỖI OBJECT THÌ ĐC 1 TÊN GỌI GỌI LÀ BIẾN OBJECT
        // Student anh = new Student(...) {...}
        //      biến       tên gọi
        //      tên gọi     object
        // mỗi Hồ sơ sv cụ thể nào là cần thêm 1 biến - tên gọi tắt tham chiếu sv đó 
        // lớp ta có 30 sv  30 NEW STUDENT () 30 BIẾn STUDENT

        //CLASS -> OBJECT: BIẾT CÁCH QUẢN LÍ INFO CỦA 1 OBJECT
        //NẾU CÓ NHIỀU OBJECT, QUẢN LÍ SAO CHO HIỂU QUẢ

        // CHALLENGE 1 : HÃY GIÚP TUI LƯU TRỮ 10 CON SỐ NGUYÊN BẤT KÌ VÀ IN RA 10 CON SỐ ĐÓ
        // CHALLENGE 2 : HÃY GIÚP TUI LƯU TRỮ HỒ SƠ 10 BẠN SV NÀO ĐÓ , SAU ĐÓ:
        // IN RA DANH SÁCH SV QUÊ Ở???
        // IN RA DANH SÁCH SV CÓ ĐIỂM TB >= 8
        // IN RA DANH SÁCH SV TĂNG DẦN THEO TÊN GỌI
        // IN RA DANH SÁCH SV CÓ ĐIỂM TB < 4 
        // IN ...
        // LÀM SAO QUẢN LÍ VÀ LƯU TRỮ ĐC NHIỀU INFO , NHIỀU VALUE, NHIỀU OBJECT -> LƯU ĐC XỬ LÍ ĐC 


        static void PlayWithPrimitiveArray()
        {
            //hãy giúp tui lưu đc 10 con số nguyên 
            // Có 3 cách:
            // C1: KHAI BÁO 10 BIẾN LẺ
            // 1 value kèm 1 biến , 1 value có 1 tên gọi
            // biến la tên gọi cho 1 value
            // biến là 1 vùng ram đc đặt tên chứa 1 value tại 1 thời điểm
            // int yob = 2003;
            // 10 BIẾN SẼ ỨNG 10 CON SỐ NGUYÊN
            int a = 5; int b = 10; int c = 15; int d = 20; int e = 25; int f = 30; int g = 35; int h = 40; int i = 45; int j = 50;
            // dễ làm dễ hiểu nhưng ko hiểu quả, thủ công trong thao tác lập trình 

            // C2: KHAI BÁO 10 BIẾN SỈ
            //   C2.1: DÙNG MẢNG
            //   C2.2: DÙNG COLLECTION: LIST, SET, MAP (JAVA)
            //
            //DÙNG MẢNG
            // MẢNG LÀ KỸ THUẬT KHAI BÁO NHIỀU BIẾN (BIẾN CHỨA VALUE) CÙNG LÚC, CÙNG KIỂU, CÙNG TÊN
            int[] arr1 = new int[10]; // đã có 10 biến rồi ,thiếu value!!!
            // 10 biến cùng chung cái tên arr1, làm sao phân biệt từng đứa => TÊN PHỤ [SỐ THỨ TỰ] 
            // arr1[0], arr1[1], arr1[2], arr1[3],...
            // số thứ tự đếm từ 0
            // gán value: arr1[0] = 79; arr1[1] = 39;...
            arr1[0] = 79;
            arr1[1] = 39;

            int[] arr2 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40 };
            // vừa khai báo vừa gán value cho các biến 

            int[] arr3 = { 5, 10, 15, 20, 25, 30, 35, 40 };     // giống cách 2 nhưng lượt bớt new

            // Mỗi biến nhỏ trong MẢNG có tên là [index] (tính từ 0)
            // do đó, duyệt mảng tức là lấy ra các biến của mảng để dùng
            // ==> DÙNG VÒNG LẶP FOR (DO, WHILE)

            // In các biến trong mảng
            //  + In lẻ từng biến
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr1[1] = " + arr1[1]);
            //Console.WriteLine("arr1[9] = " + arr1[9]);

            //  + In đồng loạt
            //Console.WriteLine("The array arr3 has value of...");
            //for (i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine($"arr1[{i}] = {arr3[i]}");
            //}

            Console.WriteLine("The array arr3 has value of... (using foreach)");
            foreach (var x in arr3)
            {
                Console.Write(x + " ");
            }
        }

        static void PlayWithStudentList()
        {
            Student s1 = new Student() { Id = "SE1", Name = "An", Yob = 2003, Gpa = 9.9 };
            Student s2 = new Student() { Id = "SE2", Name = "Binh" };

            Student[] students = new Student[30];   // Có 30 biến sinh viên 
                                                    // với tên gọi student[0], student[1], student[2],...
                                                    // đang chờ gán vào = new Sudent() {}

            students[0] = s1;   //2 thằng cùng trỏ 1 vùng new

            // CHỨNG MINH 
            //Console.WriteLine("s1: " + s1); //ToString()

            //students[0].Gpa = 5.0;

            //Console.WriteLine("s1: " + s1);


            students[1] = s2;
            students[2] = s1;
            students[3] = new Student() { Id = "SE3", Name = "Cuong" };
            students[4] = new Student() { Id = "SE4", Name = "Dung" };

            Console.WriteLine("Student List (using for): ");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("Student List (using foreach): ");
            foreach (var x in students)
            {
                Console.WriteLine(x);
            }

            // QUAN TRỌNG: Khi chơi vs mảng, không được in đến hết mảng (không dùng vòng lặp FOR hoặc FOREACH) 
            // vì mảng chưa full thì phần còn lại in ra trống rỗng
            // FOR đến số phần tử đang có giá trị, FOR đến COUNT
            // COUNT++ giúp mảng từ từ đẩy từ trái sang phải đến khi full == length
        }
    }
}
