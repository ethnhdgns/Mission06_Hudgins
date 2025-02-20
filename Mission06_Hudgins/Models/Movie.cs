using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hudgins.Models;

    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; } // required (obv, it's a key)
        
        [ForeignKey("CategoryId")]
        public int? CategoryID { get; set; } 
        public Category? Category { get; set; }
        public string Title { get; set; } // required
        public int Year { get; set; } // required
        public string? Director { get; set; } 
        public string? Rating { get; set; } 
        public bool Edited { get; set; } // required
        public string? LentTo { get; set; } 
        public bool CopiedToPlex { get; set; } // required
        public string? Notes { get; set; }
    }
