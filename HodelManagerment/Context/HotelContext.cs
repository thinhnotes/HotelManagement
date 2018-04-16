using HodelManagement.Entity;
using Microsoft.EntityFrameworkCore;

namespace HodelManagement.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Entity.Services> Serviceses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
