using EasyEOrder.Dal.Entities;
using EasyEOrder.Dal.Entities.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


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
            //builder.Entity<Restaurant>()
            //       .HasOne(a => a.Menu)
            //       .WithOne(b => b.Restaurant)
            //       .HasForeignKey<Menu>(b => b.RestaurantId);
            //builder.Entity<Table>()
            //    .HasOne(a => a.Reservation)
            //    .WithOne(b => b.Table)
            //    .HasForeignKey<Reservation>(b => b.TableId);

            //builder.Entity<Chapter>()
            //       .HasOne(a => a.Discussion)
            //       .WithOne(b => b.Chapter)
            //       .HasForeignKey<Discussion>(b => b.ChapterId);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Food>().ToTable("Food");
        //    //modelBuilder.Entity<Comment>().ToTable("Comment");
        //    //modelBuilder.Entity<Menu>().ToTable("Menu");
        //    //modelBuilder.Entity<Order>().ToTable("Order");
        //    //modelBuilder.Entity<Reservation>().ToTable("Reservation");
        //    //modelBuilder.Entity<Table>().ToTable("Table");
        //}

    }
}
