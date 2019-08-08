using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopkartCore.DBContext
{
    public class TopkartDBContext : DbContext
    {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }


        public TopkartDBContext(DbContextOptions<TopkartDBContext> options) :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressAlias).HasMaxLength(200);
                entity.Property(e => e.Name).HasMaxLength(200);
                entity.Property(e => e.HouseNo).HasMaxLength(50);
                entity.Property(e => e.Area).HasMaxLength(500);
                entity.Property(e => e.City).HasMaxLength(200);
                entity.Property(e => e.State).HasMaxLength(200);
                entity.Property(e => e.Country).HasMaxLength(200);
                entity.Property(e => e.Zipcode).HasMaxLength(10);


                entity.HasOne(e => e.Buyer)
                    .WithMany(e => e.Addresses)
                    .HasForeignKey(e => e.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_Buyer_BuyerId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.Location).HasMaxLength(50);
                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.HasOne(e => e.User)
                    .WithOne(e => e.Buyer)
                    .HasForeignKey<Buyer>(e => e.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buyer_User_UserId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasOne(e => e.Buyer)
                    .WithMany(e => e.Cart)
                    .HasForeignKey(e => e.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Buyer_BuyerId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<Order>(entity => {

                entity.HasOne(b => b.Buyer)
                    .WithMany(o => o.Orders)
                    .HasForeignKey(b => b.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Buyer_BuyerId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);

            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasOne(e => e.Order)
                    .WithMany(e => e.OrderItems)
                    .HasForeignKey(e => e.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Order_OrderId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.StockQuantity).IsRequired();


                entity.HasOne(e => e.Seller)
                    .WithMany(e => e.Products)
                    .HasForeignKey(e => e.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Sellers_SellerId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.RoleName).HasMaxLength(20);
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasData(
                        new Role() { Id = 1, RoleName = "Admin", Description = "Administrator" },
                        new Role() { Id = 2, RoleName = "Seller", Description = "Seller of products" },
                        new Role() { Id = 3, RoleName = "Buyer", Description = "Buyer of products" });

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);

            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.Property(e => e.SellerName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Bio).HasMaxLength(500);
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(15);
                entity.Property(e => e.Location).HasMaxLength(50);

                entity.HasOne(e => e.User)
                    .WithOne(e => e.Seller)
                    .HasForeignKey<Seller>(e => e.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sellers_Users_UserId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();

                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Password).HasMaxLength(16);

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });

            modelBuilder.Entity<UserRole>(entity => 
            {

                entity.HasOne(ur => ur.User)
                    .WithOne(u => u.UserRole)
                    .HasForeignKey<UserRole>(ur => ur.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Users_UserId");

                entity.HasOne(u => u.Role)
                    .WithOne(u => u.UserRole)
                    .HasForeignKey<UserRole>(u => u.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role_RoleId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);

            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.HasOne(e => e.Buyer)
                    .WithMany(e => e.Wishlist)
                    .HasForeignKey(e => e.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_Buyer_BuyerId");

                entity.Property(e => e.Created).HasDefaultValue<DateTime>(DateTime.Now);
            });


        }
    }

}
