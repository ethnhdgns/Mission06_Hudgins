using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hudgins.Models;

    public class Movie
    {
        public int MovieID { get; set; } 
        public int CategoryID { get; set; } 
        public string Title { get; set; } 
        public int Year { get; set; } 
        public string Director { get; set; } 
        public string Rating { get; set; } 
        public bool Edited { get; set; } 
        public string LentTo { get; set; } // Optional field
        public bool CopiedToPlex { get; set; }
        public string Notes { get; set; } // Optional field
        }
    }
