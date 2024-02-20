using System.ComponentModel.DataAnnotations;

namespace Mission06_Brammer.Models
{
    public class CategoryM
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; } 
    }
}
