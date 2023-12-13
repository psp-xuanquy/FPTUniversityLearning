using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Repositories.Entities;

namespace Repositories.Repositories
{
    public partial class BookManagement2023DBContext : DbContext
    {
        public BookManagement2023DBContext()
        {
        }

        public BookManagement2023DBContext(DbContextOptions<BookManagement2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<BookCategory> BookCategories { get; set; } = null!;
        public virtual DbSet<BookManagementMember> BookManagementMembers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=BookManagement2023DB;User ID=sa;Password=123;Trusted_Connection=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookId).ValueGeneratedNever();

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.BookName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.BookCategory)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.BookCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_BookCategory");
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.ToTable("BookCategory");

                entity.Property(e => e.BookCategoryId).ValueGeneratedNever();

                entity.Property(e => e.BookGenreType).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<BookManagementMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("BookManagementMember");

                entity.Property(e => e.MemberId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
