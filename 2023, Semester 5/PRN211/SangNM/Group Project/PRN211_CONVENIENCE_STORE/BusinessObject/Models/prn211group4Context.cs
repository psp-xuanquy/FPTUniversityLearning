using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject.Models
{
    public partial class prn211group4Context : DbContext
    {
        public prn211group4Context()
        {
        }

        public prn211group4Context(DbContextOptions<prn211group4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblStaff> TblStaffs { get; set; }
        public virtual DbSet<TblStatus> TblStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database=PRN211Project;uid=sa;pwd=12345; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblCategories");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(10)
                    .HasColumnName("categoryID")
                    .IsFixedLength(true);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(10)
                    .HasColumnName("categoryName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tblOrders");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(25)
                    .HasColumnName("customerName")
                    .IsFixedLength(true);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.OrderPrice).HasColumnName("orderPrice");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(20)
                    .HasColumnName("paymentMethod")
                    .IsFixedLength(true);

                entity.Property(e => e.StaffId)
                    .HasMaxLength(15)
                    .HasColumnName("staffID")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId)
                    .HasMaxLength(15)
                    .HasColumnName("statusID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_tblOrders_tblStaff");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_tblOrders_tblStatus");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.ToTable("tblOrderDetails");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(15)
                    .HasColumnName("productID")
                    .IsFixedLength(true);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetails_tblOrderDetails");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetails_tblProducts");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tblProducts");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(15)
                    .HasColumnName("productID")
                    .IsFixedLength(true);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(10)
                    .HasColumnName("categoryID")
                    .IsFixedLength(true);

                entity.Property(e => e.ImageSrc)
                    .HasMaxLength(50)
                    .HasColumnName("imageSrc")
                    .IsFixedLength(true);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(30)
                    .HasColumnName("productName")
                    .IsFixedLength(true);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(15)
                    .HasColumnName("statusID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_tblProducts_tblCategories");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_tblProducts_tblStatus");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tblRoles");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(15)
                    .HasColumnName("roleID")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(15)
                    .HasColumnName("roleName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("tblStaff");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(15)
                    .HasColumnName("staffID")
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.FullName)
                    .HasMaxLength(25)
                    .HasColumnName("fullName")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(15)
                    .HasColumnName("roleID")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId)
                    .HasMaxLength(15)
                    .HasColumnName("statusID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblStaffs)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_tblStaff_tblRoles");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblStaffs)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_tblStaff_tblStatus");
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblStatus");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(15)
                    .HasColumnName("statusID")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusName)
                    .HasMaxLength(20)
                    .HasColumnName("statusName")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
