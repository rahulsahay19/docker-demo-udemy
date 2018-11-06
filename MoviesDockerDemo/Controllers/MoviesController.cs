using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesDockerDemo.Data;

namespace MoviesDockerDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/movies")]
    public class MoviesController : Controller
    {
        private readonly MovieContext _movieContext;

        public MoviesController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _movieContext.Movies.ToListAsync());
        }
    }
}