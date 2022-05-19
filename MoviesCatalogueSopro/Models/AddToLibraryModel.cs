using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCatalogueSopro.Models
{
    public class AddToLibraryModel
    {
        public int libraryId { get; set; }
        public int movieId { get; set; }
        public List<Movie> Movies { get; set; }
        public AddToLibraryModel()
        {
            Movies = new List<Movie>();
        }
    }
}
