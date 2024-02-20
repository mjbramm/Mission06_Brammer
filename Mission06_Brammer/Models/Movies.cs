using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Brammer.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public CategoryM Category { get; set; }

        [Required]
        public string Title { get; set; }
        [Range(1888, 2030, ErrorMessage = "You must enter a valid year")]
        [Required]
        public int Year { get; set; } = 2000;
        public string? Director { get; set; }
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
