using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data.Models;

namespace ToDoAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<ToDo> ToDos => Set<ToDo>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // tag Name must be unique
            modelBuilder.Entity<Tag>()
                .HasIndex(tag => tag.Name)
                .IsUnique();

        }
    }
}
