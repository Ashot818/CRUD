using Microsoft.EntityFrameworkCore;

namespace CRUD.DataAccess
{
    public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
    {

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(e => e.Id);
            modelBuilder.Entity<Note>().Property(e => e.Text).HasMaxLength(140);
            base.OnModelCreating(modelBuilder);
        }
    }
}
