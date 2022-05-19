using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCatalogueSopro.Models
{
    public class Library
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Movie> movies { get; set; }
        public Library()
        {
            movies = new List<Movie>();
        }
    }
}
