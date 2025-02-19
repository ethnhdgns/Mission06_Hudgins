using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hudgins.Models;

    public class Movie
    {
        
        [Key]
        [Required]
        public int CategoryId { get; set; }
        // these are all the values im taking from the addmovies form
        [ForeignKey("CategoryId")]
        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_to { get; set; }

        public string Notes { get; set; }
    }