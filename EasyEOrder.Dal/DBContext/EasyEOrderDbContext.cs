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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<FoodAllergen> FoodAllergens { get; set; }
        public DbSet<DayOfWeekOpenTimes> DayOfWeekOpenTimes { get; set; }
        public DbSet<OpenTime> OpenTimes { get; set; }
        public DbSet<CartFood> CartFoods { get; set; }


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

            //builder.Entity<Cart>()
            //     .HasMany(a => a.Foods)
            //     .WithOne(b => b.Cart)
            //     .HasForeignKey(b => b.OrderId);

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

            builder.Entity<CartFood>()
                          .HasOne(x => x.Food)
                          .WithMany(x => x.CartFoods)
                          .HasForeignKey(x => x.FoodId)
                          .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CartFood>()
                        .HasOne(x => x.Cart)
                        .WithMany(x => x.CartFoods)
                        .HasForeignKey(x => x.CartId)
                        .OnDelete(DeleteBehavior.Restrict);
            var role = new IdentityRole("Admin");
            builder.Entity<IdentityRole>().HasData(role);

            var Admin = new MyUser
            {
                Id = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                Email = "admin@admin.admin",
                NormalizedEmail = "ADMIN@ADMIN.ADMIN",
                UserName = "admin@admin.admin",
                NormalizedUserName = "ADMIN@ADMIN.ADMIN",
                SecurityStamp = "string",
                EmailConfirmed = true,
                Title = "Üzletvezető"

            };

            var user = new MyUser
            {
                Id = "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                Email = "test@test.test",
                NormalizedEmail = "TEST@TEST.TEST",
                UserName = "test@test.test",
                NormalizedUserName = "TEST@TEST.TEST",
                SecurityStamp = "string",
                EmailConfirmed = true,
                Title = "Vásárló"
            };

            var password = new PasswordHasher<MyUser>();
            var hashed = password.HashPassword(user, "123456");
            var hashed2 = password.HashPassword(Admin, "123456");
            Admin.PasswordHash = hashed2;
            user.PasswordHash = hashed;

            builder.Entity<MyUser>().HasData(Admin);
            builder.Entity<MyUser>().HasData(user);

            // First reastaurant

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
                Id = new System.Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d"),
                Name = "Da Giovanni",
                Address = "Bp., 1117 Karinthy F. út 22",
                Email = "Da-Giovanni@pizza.hu",
                MenuId = new System.Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c01"),

            });

            builder.Entity<Menu>().HasData(new Menu
            {
                Id = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Name = "Olasz Pizzak",
                RestaurantId = new System.Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d"),
            });

            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b451"),
                Name = "Húsos pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description =
            "At vero eos et accusamus et iusto odio " +
            "dignissimos ducimus qui blanditiis praesentium " +
            "voluptatum deleniti atque corrupti quos dolores et qu" +
            "as molestias excepturi sint occaecati cupiditate non provident," +
            " similique sunt in culpa qui officia deserunt mollitia animi," +
            " id est laborum et dolorum fuga. ",
                Price = 1650,
                IsAvailable = true,
                Rating = 4,
                Category = Entities.Enums.FoodCategories.soup,

            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b452"),
                Name = "Mozzarellás pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Finom mozzarella darabokkal a sajt kedvelőknek.",
                Price = 1510,
                IsAvailable = true,
                Rating = 3,
                Category = Entities.Enums.FoodCategories.soup,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b453"),
                Name = "Halas pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Friss és ízletes alapanyagokból készítve",
                Price = 1800,
                IsAvailable = true,
                Rating = 1,
                Category = Entities.Enums.FoodCategories.soup,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b454"),
                Name = "Vegetáriánus pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Elkészítéséhez hozzáértő szakácsunk saját receptjeit használja, hogy eredeti olasz pizza kerüljön ki a keze alól.",
                Price = 2000,
                IsAvailable = true,
                Rating = 4,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b455"),
                Name = "Tejszínes pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Nálunk a tejszínes pizzák is magas színvonalon készülnek.",
                Price = 1680,
                IsAvailable = true,
                Rating = 3,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b456"),
                Name = "Capriciosa pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Tányérunkra varázsolja az eredeti olasz ízeket.",
                Price = 2100,
                IsAvailable = true,
                Rating = 2,
                Category = Entities.Enums.FoodCategories.meat,
            });
            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("63c299af-c574-42d7-9b74-a0904a96b457"),
                Name = "Hawaii pizza",
                MenuId = new System.Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"),
                Description = "Mindegyikhez minőségi alapanyagokat használunk, mivel mi a minőségi ételek elkötelezettjei vagyunk.",
                Price = 1400,
                IsAvailable = true,
                Rating = 10,
                Category = Entities.Enums.FoodCategories.meat,
            });



            // Second reastaurant --------------------------------------------------------------------

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
                Description =
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
                Description = "Description",
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
                Description = "Description",
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
                Description = "Descriptionasd",
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
                Description = "Description",
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
                Description = "Description",
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
                Description = "Description",
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

            builder.Entity<Cart>().HasData(new Cart
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

