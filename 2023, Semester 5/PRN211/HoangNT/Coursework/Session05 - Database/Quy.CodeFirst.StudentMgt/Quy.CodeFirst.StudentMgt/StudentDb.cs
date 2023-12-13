using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.CodeFirst.StudentMgt
{
    internal class StudentDb : DbContext
    {
        private string _connectionstr = "Server=(local);Database=AhihiDB;Uid=sa;Pwd=123;Trusted_Connection=True;Trust Server Certificate=True";

        //class này kế thừa class DbContext có sẵn trong EntityFrameWorkCore
        //chứa các lệnh để giúp ta nối xuống CSDL
        //chứa các lệnh/khai báo giúp ta đồng bộ data trong object xuống Db và ngược lại
        //Để xài nó, ta cần khai báo 1 vài thông tin gồm:
            //Danh sách các table có trong CSDL
            //chuối kết nối tới server (SQLServer, MySQL...)
            //override hàm kết nối CSDL dùng chuỗi kết nối của riêng ta

        public DbSet<Student> Students { get; set; }
        //Students ngầm hiểu là List<Student> lấy từ CSDL
        //Có bao nhiêu table/class muốn cắt xuống Db thì khai báo thêm ở đây - dùng DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionstr);
        }
    }
}
