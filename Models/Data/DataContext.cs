using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}