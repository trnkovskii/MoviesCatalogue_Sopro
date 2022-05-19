using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCatalogueSopro.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name="Genre")]
        public int GenreId { get; set; }
        [Display(Name = "Person Role")]
        public int PersonId { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Movie Image")]
        public string MovieUrl { get; set; }
        public Genre Genre { get; set; }
        public Person People { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public decimal Rating { get; set; }
        [Display(Name = "IMDB  Link")]
        public string Link { get; set; }
        public virtual List<Library> libraries { get; set; }
        public Movie()
        {
            libraries = new List<Library>();
        }
    }
}
