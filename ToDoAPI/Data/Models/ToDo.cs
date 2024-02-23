using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAPI.Data.Models
{
    public class ToDo
    {
        /// <summary>
        /// Unique id of a todo
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Title that briefly explains task
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Description that gives more insight on a task
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Shows importance of the task: High, Medium, Low
        /// </summary>
        [Column(TypeName = "tinyint")]
        public ToDoPriority Priority { get; set; }

        /// <summary>
        /// The status of the task: Pending, InProgress, Completed
        /// </summary>
        [Column(TypeName = "tinyint")]
        public ToDoStatus Status { get; set; }

        /// <summary>
        /// The date by which the task should be completed
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The date when the task was completed
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Set of unique Tags that categorize the task
        /// </summary>
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

    }

    public enum ToDoPriority
    {
        High = 1,
        Medium = 2,
        Low = 3
    }

    public enum ToDoStatus
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3
    }
}
