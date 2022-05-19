using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MoviesCatalogueSopro.Models;

namespace MoviesCatalogueSopro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MoviesCatalogueSopro.Models.Movie> Movie { get; set; }
        public DbSet<MoviesCatalogueSopro.Models.Genre> Genre { get; set; }
        public DbSet<MoviesCatalogueSopro.Models.Person> Person { get; set; }
        public DbSet<MoviesCatalogueSopro.Models.Library> Library { get; set; }
    }
}
