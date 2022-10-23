using Asp.Net_6_code_first.Interfaces;
using Asp.Net_6_code_first.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_6_code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

         private readonly IMovie _imovie;
       // private readonly MovieContext _movieContext;
        public MovieController(IMovie movie)
        {
            _imovie = movie;
           // _movieContext = movieContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var movies = _imovie.GetAll();
                if (movies == null) return NotFound();
                return Ok(movies);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            //IEnumerable<Movie> movie;
            //movie = _imovie.GetAll();
            //return Ok(movie);

        }

        [HttpPost]
        public IActionResult Post(Movie movie)
        {
            try
            {
                var model = _imovie.AddMovie(movie);
                return Accepted();
                //return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            //IEnumerable<Movie> movie;
            //movie = _imovie.GetAll();
            //return Ok(movie);

        }




    }
}
