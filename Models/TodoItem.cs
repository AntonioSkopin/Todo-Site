using System.ComponentModel.DataAnnotations;

namespace ToDo_App.Models
{
    public class TodoItem
    {
        [Key]
        public int id { get; set; }
        public string taskName { get; set; }
        public bool isCompleted { get; set; }
    }
}
