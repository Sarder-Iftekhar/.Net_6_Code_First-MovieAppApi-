using Asp.Net_6_code_first.Model;

namespace Asp.Net_6_code_first.Interfaces
{
    public interface IMovie
    {
        List<Movie> GetAll();
        Movie AddMovie(Movie movie);

    }
}
