namespace Mission06_Hudgins.Models;

    public class movies
    {
        // these are all the values im taking from the addmovies form
        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_to { get; set; }

        public string Notes { get; set; }
    }