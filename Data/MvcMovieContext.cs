using Microsoft.EntityFrameworkCore;
using Lab1_Giron_Laparra_Bech.Models;

namespace Lab1_Giron_Laparra_Bech.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}