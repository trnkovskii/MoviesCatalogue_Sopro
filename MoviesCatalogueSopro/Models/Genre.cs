using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCatalogueSopro.Models
{
    public class Genre
    {
        [Display(Name = "Id")]
        public int GenreId { get; set; }
        [Display(Name = "Genre Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
