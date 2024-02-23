using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data.Models;

namespace ToDoAPI.Data
{
    public static class SeedHelper
    {
        private static Tag[] tags =
        {
            new Tag
            {
                Id = 1,
                Name = "Duolingo"
            },
            new Tag
            {
                Id = 2,
                Name = "Coding"
            },
            new Tag
            {
                Id = 3,
                Name = "Languages"
            }
        };

        private static ToDo[] todos =
        {
            new ToDo
            {
                Id = 1,
                Title = "Complete level 7 on Duolingo",
                Description = string.Empty,
                Priority = ToDoPriority.Medium,
                Status = ToDoStatus.Pending,
                DueDate = DateTime.UtcNow.AddDays(1),
            },
            new ToDo
            {
                Id = 2,
                Title = "Solve 5 Codewars challenges",
                Description = "At least one challenge must be level 5",
                Priority = ToDoPriority.Medium,
                Status = ToDoStatus.Completed,
                DueDate = DateTime.UtcNow.AddDays(-2).AddHours(3),
                CompletionDate = DateTime.UtcNow.AddHours(-12),
            },
            new ToDo
            {
                Id = 3,
                Title = "TTMIK weekly vocab",
                Description = "Finish week 2, day 6",
                Priority = ToDoPriority.Medium,
                Status = ToDoStatus.InProgress,
                DueDate = DateTime.UtcNow.AddHours(10),
            },
        };

        public static void SeedModelBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(tags);
            modelBuilder.Entity<ToDo>().HasData(todos);
            modelBuilder.Entity<Tag>()
                .HasMany(tag => tag.ToDos)
                .WithMany(todo => todo.Tags)
                .UsingEntity(builder => builder.ToTable("TagToDo")
                    .HasData(
                        new { ToDosId = 1, TagsId = 1 },
                        new { ToDosId = 1, TagsId = 3 },
                        new { ToDosId = 2, TagsId = 2 },
                        new { ToDosId = 3, TagsId = 3 }
                    )
                );
        }
    }
}
