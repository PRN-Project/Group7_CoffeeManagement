using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class CoffeeStoreManagementContext : DbContext
    {
        public CoffeeStoreManagementContext()
        {
        }

        public CoffeeStoreManagementContext(DbContextOptions<CoffeeStoreManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFood> TblFoods { get; set; }
        public virtual DbSet<TblFoodType> TblFoodTypes { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual DbSet<TblRevenue> TblRevenues { get; set; }
        public virtual DbSet<TblStaff> TblStaffs { get; set; }
        public virtual DbSet<TblTable> TblTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI\\MONKINAM;Database=CoffeeStoreManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblFood>(entity =>
            {
                entity.HasKey(e => e.FoodId)
                    .HasName("PK__tblFood__77EAEA190519E8E1");

                entity.ToTable("tblFood");

                entity.Property(e => e.FoodId).HasColumnName("foodID");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("foodName");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblFoods)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFood_tbl_FoodType");
            });

            modelBuilder.Entity<TblFoodType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__tblFoodT__F04DF11A3AF2A606");

                entity.ToTable("tblFoodType");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("typeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tblOrder__0809337D345D2F44");

                entity.ToTable("tblOrder");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.DateTime)
                    .HasColumnType("date")
                    .HasColumnName("dateTime");

                entity.Property(e => e.TableId).HasColumnName("tableID");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("money")
                    .HasColumnName("totalPrice");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrder_tblTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrder_tblStaff");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK__tblOrder__E4FEDE2ADAE4AE12");

                entity.ToTable("tblOrderDetail");

                entity.Property(e => e.OrderDetailId).HasColumnName("orderDetailID");

                entity.Property(e => e.FoodId).HasColumnName("foodID");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_tblFood");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_tblOrder");
            });

            modelBuilder.Entity<TblRevenue>(entity =>
            {
                entity.HasKey(e => e.RevenueId)
                    .HasName("PK__tblReven__966DC6C67AF195DC");

                entity.ToTable("tblRevenue");

                entity.Property(e => e.RevenueId).HasColumnName("revenueID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Revenue)
                    .HasColumnType("money")
                    .HasColumnName("revenue");
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblStaff__CB9A1CDF29871D44");

                entity.ToTable("tblStaff");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<TblTable>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK__tblTable__5408ADBA86241E2D");

                entity.ToTable("tblTable");

                entity.Property(e => e.TableId).HasColumnName("tableID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
