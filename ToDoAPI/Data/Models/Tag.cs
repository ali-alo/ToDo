using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Data.Models
{
    public class Tag
    {
        /// <summary>
        /// Primary key of Tag entity
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// A unique name of the tag
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A collection of Tasks that have been assigned with this tag
        /// </summary>
        public ICollection<ToDo> ToDos { get; set; } = new List<ToDo>();
    }
}
