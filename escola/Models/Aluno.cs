using System.ComponentModel.DataAnnotations;

namespace escola.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Disponibilidade { get; set; }
    }
}
