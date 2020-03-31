using EasyEOrder.Dal.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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

            builder.Entity<Restaurant>()
                   .HasOne(a => a.Menu)
                   .WithOne(b => b.Restaurant)
                   .HasForeignKey<Menu>(b => b.RestaurantId);

            builder.Entity<Table>()
                  .HasOne(a => a.Reservation)
                  .WithOne(b => b.Table)
                  .HasForeignKey<Reservation>(b => b.TableId);

            var user = new MyUser
            {
                Id = "test1",
                Email = "test@test.com",
                NormalizedEmail = "TEST@TEST.COM",
                UserName = "test",
                NormalizedUserName = "TEST",

            };
            var password = new PasswordHasher<MyUser>();
            var hashed = password.HashPassword(user, "asdasd");
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

            builder.Entity<Menu>().HasData(new Menu
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
            });

            builder.Entity<Food>().HasData(new Food
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
                Name = "FoodTest",
                MenuId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe844"),
                BaseInfo = "BaseInfo",
                Price = 0,
                IsAvailable = true,
                Rating = 0,
                Category = Entities.Enums.FoodCategories.soup,
            });

            builder.Entity<Table>().HasData(new Table
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                UserId = "test1",
                RestaurantId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe843"),
                ReservationId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe848"),
            });

            builder.Entity<Reservation>().HasData(new Reservation
            {
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe849"),
                From = new System.DateTime(),
                To = new System.DateTime(),
                TableId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe847"),
                UserId = "test1",
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
                Id = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe853"),
                Allergen = Entities.Enums.Allergen.Gluten,
                FoodId = new System.Guid("fe1ee058-9e79-4544-bf93-026f477fe123"),
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
                MyUserId = "test1"
            });

        }
    }
}

