using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net_6_code_first.Model
{
    public class MovieContext : IdentityDbContext<IdentityUser>
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        //what is this function????
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseOracle("User Id=TESTDB;Password=testdb;Data Source=10.11.201.14:1525/NSIDB;");
            }
        }

        //for what this function is used??I dont know 
        //do further researh for knowing better 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
