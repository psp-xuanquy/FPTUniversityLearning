using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repositories;

public partial class Sunglasses2023DbContext : DbContext
{

    public Sunglasses2023DbContext()
    {
    }
    public Sunglasses2023DbContext(string connectionString)
    {
        {
            this.Database.SetConnectionString(connectionString);
        }

    }

    public Sunglasses2023DbContext(DbContextOptions<Sunglasses2023DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Sunglass> Sunglasses { get; set; }

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
        var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

        return strConn;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.MemberAccountId).HasName("PK__Account__0FB640584D48B3E5");

            entity.ToTable("Account");

            entity.HasIndex(e => e.MemberEmail, "UQ__Account__3F37B77A16182714").IsUnique();

            entity.Property(e => e.MemberAccountId)
                .ValueGeneratedNever()
                .HasColumnName("MemberAccountID");
            entity.Property(e => e.MemberAccountPassword).HasMaxLength(70);
            entity.Property(e => e.MemberEmail).HasMaxLength(100);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasName("PK__Manufact__357E5CC1C574F17A");

            entity.ToTable("Manufacturer");

            entity.Property(e => e.ManufacturerId).HasMaxLength(30);
            entity.Property(e => e.ManufacturerDescription).HasMaxLength(250);
            entity.Property(e => e.ManufacturerName).HasMaxLength(100);
        });

        modelBuilder.Entity<Sunglass>(entity =>
        {
            entity.HasKey(e => e.SunglassesId).HasName("PK__Sunglass__4C4C38EAE6CE889E");

            entity.Property(e => e.SunglassesId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Feature).HasMaxLength(220);
            entity.Property(e => e.ManufacturerId).HasMaxLength(30);
            entity.Property(e => e.Material).HasMaxLength(40);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Shape).HasMaxLength(40);
            entity.Property(e => e.SunglassesName).HasMaxLength(100);

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Sunglasses)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Sunglasse__Manuf__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
