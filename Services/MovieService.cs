using Asp.Net_6_code_first.Interfaces;
using Asp.Net_6_code_first.Model;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net_6_code_first.Services
{
    public class MovieService:IMovie
    {
        private readonly MovieContext _db;
        public MovieService(MovieContext modelContext)
        {
            _db = modelContext;

        }

        public Movie AddMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }

        public List<Movie> GetAll()
        {
            List<Movie> movies;
            // movieList = _db.Set<Movie>().ToList();
            movies =  _db.Movies.ToList();
            return movies;

        }
    }
}
