using System.ComponentModel.DataAnnotations;

namespace escola.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
