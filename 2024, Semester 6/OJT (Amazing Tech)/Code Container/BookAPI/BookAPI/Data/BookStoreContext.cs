using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        #region
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>(e =>
            {
                e.ToTable("Order");
                e.HasKey(order => order.OrderId);
                e.Property(order => order.OrderDate).HasDefaultValueSql("getutcdate()");
                e.Property(order => order.Consignee).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(e => new { e.OrderId, e.BookId });

                entity.HasOne(e => e.Order)
                      .WithMany(e => e.OrderDetails)
                      .HasForeignKey(e => e.OrderId)
                      .HasConstraintName(nameof(OrderDetail.OrderId));

                entity.HasOne(e => e.Book)
                      .WithMany(e => e.OrderDetails)
                      .HasForeignKey(e => e.BookId)
                      .HasConstraintName(nameof(OrderDetail.BookId));
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(150);
            });
        }
    }
}
