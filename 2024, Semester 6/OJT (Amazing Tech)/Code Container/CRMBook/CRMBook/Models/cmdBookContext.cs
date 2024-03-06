using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRMBook.Models
{
    public partial class cmdBookContext : DbContext
    {
        public cmdBookContext()
        {
        }

        public cmdBookContext(DbContextOptions<cmdBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<RefeshTokens> RefreshTokens { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3HV9DU7;Initial Catalog=Book-test;User ID=sa;Password=123;Encrypt=False");
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
