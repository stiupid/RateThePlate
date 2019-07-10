using Microsoft.EntityFrameworkCore;

namespace RateThePlate.Models
{
    public partial class lannisterContext : DbContext
    {

        public lannisterContext(DbContextOptions<lannisterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Badge> Badge { get; set; }
        public virtual DbSet<CarPlate> CarPlate { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Populate();
        }
    }
}
