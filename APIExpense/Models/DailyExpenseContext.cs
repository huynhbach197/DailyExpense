using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIExpense.Models
{
    public partial class DailyExpenseContext : DbContext
    {
        public DailyExpenseContext()
        {
        }

        public DailyExpenseContext(DbContextOptions<DailyExpenseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Daily> Dailies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=128.199.213.46;Port=5432;Username=postgres;Password=nolove;Database=DailyExpense");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C.UTF-8");

            modelBuilder.Entity<Daily>(entity =>
            {
                entity.ToTable("Daily");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayBuy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("day_buy");

                entity.Property(e => e.MonthBuy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("month_buy");

                entity.Property(e => e.Nameproduct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nameproduct");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("price");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.YearBuy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("year_buy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Dailies)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("Daily_userid_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users_");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
