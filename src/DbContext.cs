// using Microsoft.EntityFrameworkCore;

// namespace ExtensionsSample
// {
//     public class SportsGroundContext : DbContext
//     {
//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             optionsBuilder.UseSqlite("Data Source=:memory:",
//                 x => x.UseNetTopologySuite());
//         }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             // base.OnModelCreating(modelBuilder);
//             modelBuilder.Entity<SportsGround>().Property(c => c.Location)
//                 .HasSrid(4326);
//         }

//         public DbSet<SportsGround> SportsGround { get; set; }
//     }
// }