﻿// <auto-generated />
using System;
using EasyEOrder.Dal.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyEOrder.Dal.Migrations
{
    [DbContext(typeof(EasyEOrderDbContext))]
    partial class EasyEOrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MyUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MyUserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe841"),
                            CommentContent = "HejHejHej",
                            FoodId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
                            MyUserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db"
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.DayOfWeekOpenTimes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<Guid?>("OpenTimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OpenTimesId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("DayOfWeekOpenTimes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe855"),
                            DayOfWeek = 0,
                            RestaurantId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe843")
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaseInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("OrderId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
                            BaseInfo = "BaseInfo",
                            Category = 1,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "FoodTest",
                            Price = 0,
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe124"),
                            BaseInfo = "BaseInfo",
                            Category = 1,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Soup1",
                            Price = 1010,
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe125"),
                            BaseInfo = "BaseInfo",
                            Category = 1,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Soup2",
                            Price = 12312,
                            Rating = 1
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe126"),
                            BaseInfo = "BaseInfoasd",
                            Category = 2,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Meal1",
                            Price = 21312,
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe127"),
                            BaseInfo = "BaseInfo",
                            Category = 2,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Meal2",
                            Price = 1230,
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe128"),
                            BaseInfo = "BaseInfo",
                            Category = 2,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Meal3",
                            Price = 3210,
                            Rating = 2
                        },
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe129"),
                            BaseInfo = "BaseInfo",
                            Category = 2,
                            IsAvailable = true,
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "Meal4",
                            Price = 4320,
                            Rating = 10
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.FoodAllergen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Allergen")
                        .HasColumnType("int");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodAllergens");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe853"),
                            Allergen = 0,
                            FoodId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe123")
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            RestaurantId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe843")
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.MyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RestaurantId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aabf90c8-2314-4264-a9b6-699fb92a6cfb",
                            Email = "test@test.test",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.TEST",
                            NormalizedUserName = "TEST@TEST.TEST",
                            PasswordHash = "AQAAAAEAACcQAAAAED2exBSGPIgj1cXtGHk196PyI7AOzw+b8nc70Gu+WLds7/dWVM8Ds8TCnYxNWK3tMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "string",
                            TwoFactorEnabled = false,
                            UserName = "test@test.test"
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.OpenTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OpenTimes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe863"),
                            From = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            To = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe851"),
                            Comment = "OrderComment",
                            OrderTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe849"),
                            TotalPrice = 2000
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TableId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe849"),
                            From = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TableId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                            To = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db"
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
                            Address = "Adress",
                            Email = "email@email.email",
                            MenuId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                            Name = "RestauranName"
                        });
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Table", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MyUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MyUserId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                            ReservationId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe848"),
                            RestaurantId = new Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
                            UserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Comment", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Food", null)
                        .WithMany("Comments")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany("Comments")
                        .HasForeignKey("MyUserId");
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.DayOfWeekOpenTimes", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.OpenTime", "OpenTimes")
                        .WithMany()
                        .HasForeignKey("OpenTimesId");

                    b.HasOne("EasyEOrder.Dal.Entities.Restaurant", null)
                        .WithMany("DayOfWeekOpenTimes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Food", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Menu", "Menu")
                        .WithMany("Foods")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyEOrder.Dal.Entities.Order", "Order")
                        .WithMany("Foods")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.FoodAllergen", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Food", "Food")
                        .WithMany("FoodAllergens")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Menu", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Restaurant", "Restaurant")
                        .WithOne("Menu")
                        .HasForeignKey("EasyEOrder.Dal.Entities.Menu", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.MyUser", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Order", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Reservation", "Reservation")
                        .WithMany("Orders")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Reservation", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.Table", "Table")
                        .WithOne("Reservation")
                        .HasForeignKey("EasyEOrder.Dal.Entities.Reservation", "TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", "User")
                        .WithOne("Reservation")
                        .HasForeignKey("EasyEOrder.Dal.Entities.Reservation", "UserId");
                });

            modelBuilder.Entity("EasyEOrder.Dal.Entities.Table", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany("Tables")
                        .HasForeignKey("MyUserId");

                    b.HasOne("EasyEOrder.Dal.Entities.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EasyEOrder.Dal.Entities.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
