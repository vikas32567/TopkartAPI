﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopkartCore.DBContext;

namespace TopkartCore.Migrations
{
    [DbContext(typeof(TopkartDBContext))]
    partial class TopkartDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopkartCore.DBContext.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressAlias")
                        .HasMaxLength(200);

                    b.Property<string>("Area")
                        .HasMaxLength(500);

                    b.Property<long>("BuyerId");

                    b.Property<string>("City")
                        .HasMaxLength(200);

                    b.Property<string>("Country")
                        .HasMaxLength(200);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 468, DateTimeKind.Local).AddTicks(5970));

                    b.Property<string>("HouseNo")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .HasMaxLength(200);

                    b.Property<string>("Zipcode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Buyer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 474, DateTimeKind.Local).AddTicks(965));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Phone")
                        .HasMaxLength(15);

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BuyerId");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 476, DateTimeKind.Local).AddTicks(4601));

                    b.Property<DateTime?>("Modified");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AddressId");

                    b.Property<long>("BuyerId");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 478, DateTimeKind.Local).AddTicks(7451));

                    b.Property<DateTime?>("Modified");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("BuyerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TopkartCore.DBContext.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 480, DateTimeKind.Local).AddTicks(9486));

                    b.Property<DateTime?>("Modified");

                    b.Property<long>("OrderId");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 485, DateTimeKind.Local).AddTicks(2489));

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("Modified");

                    b.Property<int>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long>("SellerId");

                    b.Property<int>("StockQuantity");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 487, DateTimeKind.Local).AddTicks(9950));

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Administrator",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Seller of products",
                            RoleName = "Seller"
                        },
                        new
                        {
                            Id = 3L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buyer of products",
                            RoleName = "Buyer"
                        });
                });

            modelBuilder.Entity("TopkartCore.DBContext.Seller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasMaxLength(500);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 491, DateTimeKind.Local).AddTicks(2917));

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("TopkartCore.DBContext.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 494, DateTimeKind.Local).AddTicks(1134));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<long>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TopkartCore.DBContext.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 499, DateTimeKind.Local).AddTicks(3298));

                    b.Property<DateTime?>("Modified");

                    b.Property<long>("RoleId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Wishlist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BuyerId");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 9, 0, 7, 12, 501, DateTimeKind.Local).AddTicks(5800));

                    b.Property<DateTime?>("Modified");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Address", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Buyer", "Buyer")
                        .WithMany("Addresses")
                        .HasForeignKey("BuyerId")
                        .HasConstraintName("FK_Addresses_Buyer_BuyerId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Buyer", b =>
                {
                    b.HasOne("TopkartCore.DBContext.User", "User")
                        .WithOne("Buyer")
                        .HasForeignKey("TopkartCore.DBContext.Buyer", "UserId")
                        .HasConstraintName("FK_Buyer_User_UserId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Cart", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Buyer", "Buyer")
                        .WithMany("Cart")
                        .HasForeignKey("BuyerId")
                        .HasConstraintName("FK_Cart_Buyer_BuyerId");

                    b.HasOne("TopkartCore.DBContext.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TopkartCore.DBContext.Order", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TopkartCore.DBContext.Buyer", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerId")
                        .HasConstraintName("FK_Orders_Buyer_BuyerId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.OrderItem", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderItems_Order_OrderId");

                    b.HasOne("TopkartCore.DBContext.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TopkartCore.DBContext.Product", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .HasConstraintName("FK_Products_Sellers_SellerId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Seller", b =>
                {
                    b.HasOne("TopkartCore.DBContext.User", "User")
                        .WithOne("Seller")
                        .HasForeignKey("TopkartCore.DBContext.Seller", "UserId")
                        .HasConstraintName("FK_Sellers_Users_UserId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.UserRole", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Role", "Role")
                        .WithOne("UserRole")
                        .HasForeignKey("TopkartCore.DBContext.UserRole", "RoleId")
                        .HasConstraintName("FK_UserRole_Role_RoleId");

                    b.HasOne("TopkartCore.DBContext.User", "User")
                        .WithOne("UserRole")
                        .HasForeignKey("TopkartCore.DBContext.UserRole", "UserId")
                        .HasConstraintName("FK_UserRoles_Users_UserId");
                });

            modelBuilder.Entity("TopkartCore.DBContext.Wishlist", b =>
                {
                    b.HasOne("TopkartCore.DBContext.Buyer", "Buyer")
                        .WithMany("Wishlist")
                        .HasForeignKey("BuyerId")
                        .HasConstraintName("FK_Wishlist_Buyer_BuyerId");

                    b.HasOne("TopkartCore.DBContext.Product", "Product")
                        .WithMany("Wishlists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
