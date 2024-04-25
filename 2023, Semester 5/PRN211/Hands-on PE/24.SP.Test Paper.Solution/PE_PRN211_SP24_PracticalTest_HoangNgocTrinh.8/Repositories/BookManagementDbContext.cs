using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Entities;

namespace Repositories;

//ĐÂY LÀ CLASS ĐẠI DIỆN CHO CÁI DATABASE BookManagementDb ta đang móc tới
//1 DB CÓ NHIỀU TABLE, DB GIỐNG NHƯ CABINET, THÙNG CHỨA, CONTAINER
//CLASS NÀY ~ DATABASEE ~ NÓ CHỨA BÊN TRONG NHIỀU ENTITIES/CLASS-OBJECT KHÁC
//  BookManagementDb CHỨA 3 TABLE
//      Book
//      BookCategory
//      UserAccount 

//scaffold sẽ sinh ra dàn code y chang cấu trúc DB
//  BookManagementDbContext (Cabinet)
//      List<Student>      arr ~   Students   
//      List<Book>         arr ~   Books
//      List<BookCategory> arr ~   BookCategories 
//      List<UserAccount>  arr ~   UserAccounts

//.Books ~ SELECT * FROM BOOK
//.BookCategories ~ SELECT * FROM BOOKCATEGORY

//CHÚNG ĐỀU LÀ LIST, ĐÓ LÀ LÚC ÁP DỤNG LINQ, LAMBDA EXPRESSION - DELEGATE ĐỂ THAO TÁC TRÊN TABLE - TRONG RAM

//.WHERE(BIỂU THỨC LAMDA ĐỂ LÀM GÌ ĐÓ VỚI TABLE ĐANG TRONG RAM)
//.SELECT(BIỂU THỨC LAMBDA)
//.

//CÒN RẤT NHIỀU METHOD KHÁC ĐỂ THAO TÁC TRÊN CSDL: UPDATE(), ADD(), ...

//TUY NHIÊN - CLASS NÀY ĐC TẠO TỰ ĐỘNG BỞI CON KỲ LÂN EF 8 TA CÀI TỪ CMD
//            VÀ NÓ NHÚNG LUÔN CÂU LỆNH KẾT NỐI CSDL VÀO TRONG CLASS NÀY LUÔN
//            VÌ NÓ PHẢI MÓC VÀO CSDL THÌ NÓ MỚI THAO TÁC TABLE ĐC - HARD-CODED
//                                                         CONNECTION STRING
//HARD-CODED CONNECTION STRING (CS) NGUY HIỂM BỊ BỊ LỘ THÔNG TIN SERVER TRONG FILE .DLL SẼ BỊ DỊCH NGƯỢC BỞI DOTPEEK...
//HARD-CODED CS KHIẾN APP CHỈ CHƠI ĐC VỚI ĐÚNG 1 SERVER, 1 CẶP USER/PASS CỐ ĐỊNH
//=> TA CẦN LINH HOẠT HƠN, APP CHẠY VỚI MỌI SERVER
//=> TA CẦN GIẤU INFO SERVER 

//=> TÁCH, GỠ PHẦN CS RA KHỎI CLASS NÀY
//=> CLASS NÀY SẼ ĐỌC INFO CẤU HÌNH, CHUỖI CS TỪ 1 TẬP TIN BÊN NGOÀI ĐẶT Ở THƯ MỤC NÀO ĐÓ | THƯ MỤC GUI APP
//TẬP TIN CHỨA INFO KẾT NỐI CSDL - GỌI LÀ CONFIGURATION FILE
//NÓ LÀ FILE TEXT THUẦN NHƯNG CÓ ĐỊNH DẠNG TRONG CONTENTS ĐỂ ĐỌC THÔNG TIN
//NÓ THƯỜNG CÓ DẠNG .INI      .XML      .JSON

//TRONG CLASS NÀY TA ĐỌC FILE CẤU HÌNH .JSON ĐỂ LẤY RA CONNECTION STRING THAY VÀO HÀM HARD-CODED. 
//ĐỂ ĐỌC TẬP TIN .JSON TA CẦN THÊM 2 THƯ VIỆN PHỤ TRỢ!!! NUGET MANAGE PACKAGES QUAY TRỞ LẠI
//ĐỀ THI CHO BẠN CONTENT CỦA TẬP TIN .JSON, COPY & PASTE
//ĐỀ THI CHO TÊN THƯ VIỆN ĐỌC .JSON
//ĐỀ THI CHO HÀM ĐỌC .JSON LUÔN - COPY & PASTE
//BẠN CHỈ CÒN VIỆC SỬA CHỖ HARD-CODED THAY = HÀM ĐỌC FILE JSON!!!

public partial class BookManagementDbContext : DbContext
{
    public BookManagementDbContext()
    {
    }

    public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }


    //hàm đọc file .json để trả về Connection String
    //đọc các tag, property của file JSON và mò ra cái chuỗi kết nối CSDL
    //NHỚ CHECK CÁI CHUỖI KẾT NỐI - SỬA USER/PASS MÁY BẠN
    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DefaultConnectionStringDB"];
    }                    //HỌC PHÍ 9M NẰM Ở ĐÂY, COI CHỪNG DẤU CÁCH GIỮA 2 TAG

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());
                                  //REMOVE HAERD-CODED CONNECTION STRING
                                  //THAY BẰNG LỜI GỌI HÀM ĐỌC FILE JSON  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C2074DA30FBD");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_BookCategory");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.BookCategoryId).HasName("PK__BookCate__6347EC047AE2371B");

            entity.ToTable("BookCategory");

            entity.Property(e => e.BookCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BookGenreType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__UserAcco__0CF04B18AEF11AF8");

            entity.ToTable("UserAccount");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
