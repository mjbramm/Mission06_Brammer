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
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }
        [Range(1888, 2030, ErrorMessage = "You must enter a valid year")]
        [Required]
        public int Year { get; set; } = 2000;
        public string? Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? Lent_To { get; set; }
        public string? Notes { get; set; }
    }
}
