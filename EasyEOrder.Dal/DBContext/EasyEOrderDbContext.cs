using EasyEOrder.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

namespace EasyEOrder.Dal.DBContext
{
    public class EasyEOrderDbContext : IdentityDbContext<MyUser>
    {
        public EasyEOrderDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        //{
        //}

        public DbSet<Food> Foods { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<FoodAllergen> FoodAllergens { get; set; }
        public DbSet<DayOfWeekOpenTimes> DayOfWeekOpenTimes { get; set; }
        public DbSet<OpenTime> OpenTimes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Table>()
                  .HasOne(a => a.Reservation)
                  .WithOne(b => b.Table)
                  .HasForeignKey<Reservation>(b => b.TableId);

            builder.Entity<Menu>()
                .HasMany(a => a.Foods)
                .WithOne(b => b.Menu)
                .HasForeignKey(b => b.MenuId);

            builder.Entity<Food>()
                .HasMany(a => a.FoodAllergens)
                .WithOne(b => b.Food)
                .HasForeignKey(b => b.FoodId);

            builder.Entity<Order>()
                 .HasMany(a => a.Foods)
                 .WithOne(b => b.Order)
                 .HasForeignKey(b => b.OrderId);

            builder.Entity<Restaurant>()
                   .HasMany(a => a.Tables)
                   .WithOne(b => b.Restaurant)
                   .HasForeignKey(b => b.RestaurantId);

            builder.Entity<Restaurant>()
                  .HasMany(a => a.Employees)
                  .WithOne(b => b.Restaurant)
                  .HasForeignKey(b => b.RestaurantId);

            builder.Entity<Restaurant>()
                  .HasOne(a => a.Menu)
                  .WithOne(b => b.Restaurant)
                  .HasForeignKey<Menu>(b => b.RestaurantId);

            builder.Entity<MyUser>()
                  .HasOne(a => a.Reservation)
                  .WithOne(b => b.User)
                  .HasForeignKey<Reservation>(b => b.UserId);


            var user = new MyUser
            {
                Id = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                Email = "test@test.test",
                NormalizedEmail = "TEST@TEST.TEST",
                UserName = "test@test.test",
                NormalizedUserName = "TEST@TEST.TEST",
                SecurityStamp = "string",
                EmailConfirmed = true
            };
            var password = new PasswordHasher<MyUser>();
            var hashed = password.HashPassword(user, "123456");
            user.PasswordHash = hashed;

            builder.Entity<MyUser>().HasData(user);

            builder.Entity<Restaurant>().HasData(new Restaurant
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
                Name = "RestauranName",
                Address = "Adress",
                Email = "email@email.email",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),

            });

            builder.Entity<Restaurant>().HasData(new Restaurant
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe899"),
                Name = "RestauranTest",
                Address = "Adress",
                Email = "email@email.email",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe855"),

            });

            builder.Entity<Menu>().HasData(new Menu
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                Name = "BestMenu",
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
            });
            builder.Entity<Menu>().HasData(new Menu
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe855"),
                Name = "TestMenu",
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe899"),
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
                Name = "FoodTest",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo =
                "At vero eos et accusamus et iusto odio " +
                "dignissimos ducimus qui blanditiis praesentium " +
                "voluptatum deleniti atque corrupti quos dolores et qu" +
                "as molestias excepturi sint occaecati cupiditate non provident," +
                " similique sunt in culpa qui officia deserunt mollitia animi," +
                " id est laborum et dolorum fuga. ",
                Price = 0,
                IsAvailable = true,
                Rating = 4,
                Category = Entities.Enums.FoodCategories.soup,
               
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe124"),
                Name = "Soup1",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 1010,
                IsAvailable = true,
                Rating = 3,
                Category = Entities.Enums.FoodCategories.soup,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe125"),
                Name = "Soup2",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 12312,
                IsAvailable = true,
                Rating = 1,
                Category = Entities.Enums.FoodCategories.soup,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe126"),
                Name = "Meal1",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfoasd",
                Price = 21312,
                IsAvailable = true,
                Rating = 4,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe127"),
                Name = "Meal2",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 1230,
                IsAvailable = true,
                Rating = 3,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe128"),
                Name = "Meal3",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 3210,
                IsAvailable = true,
                Rating = 2,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe129"),
                Name = "Meal4",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 4320,
                IsAvailable = true,
                Rating = 10,
                Category = Entities.Enums.FoodCategories.meat,
            });

            builder.Entity<Table>().HasData(new Table
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                UserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                Number = 1,
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
                ReservationId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe848"),
            });

            builder.Entity<Reservation>().HasData(new Reservation
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe849"),
                From = new System.DateTime(),
                To = new System.DateTime(),
                TableId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                UserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
            });

            builder.Entity<Order>().HasData(new Order
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe851"),
                ReservationId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe849"),
                OrderTime = new System.DateTime(),
                TotalPrice = 2000,
                Comment = "OrderComment",

            });

            builder.Entity<FoodAllergen>().HasData(new FoodAllergen
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe321"),
                Allergen = Entities.Enums.Allergen.Gluten,
                FoodId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123")
            });
            builder.Entity<FoodAllergen>().HasData(new FoodAllergen
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe322"),
                Allergen = Entities.Enums.Allergen.Laktoz,
                FoodId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123")
            });

            builder.Entity<OpenTime>().HasData(new OpenTime
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe863"),
                From = new System.DateTime(),
                To = new System.DateTime()
            });

            builder.Entity<DayOfWeekOpenTimes>().HasData(new DayOfWeekOpenTimes
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe855"),
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843")
            });

            builder.Entity<Comment>().HasData(new Comment
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe841"),
                CommentContent = "HejHejHej",
                FoodId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
                MyUserId = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db"
            });

        }
    }
}

