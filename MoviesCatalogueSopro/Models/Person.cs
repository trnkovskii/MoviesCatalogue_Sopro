using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCatalogueSopro.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Display(Name = "Person Role")]
        [Required]
        public string Name { get; set; }
    }
}
