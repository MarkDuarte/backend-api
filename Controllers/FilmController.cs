using film_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace film_api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class FilmController : ControllerBase {
    private static List<Film> films = new List<Film>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AddFilm([FromBody]Film film) {
      film.Id = id++;
      films.Add(film);
      return CreatedAtAction(nameof(getFilm), new { id = film.Id }, film );
    }

    [HttpGet]
    public IEnumerable<Film> getFilms([FromQuery] int skip = 0, [FromQuery] int take = 50) {
      return films.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult getFilm(int id) {
      var film = films.FirstOrDefault(film => film.Id == id);
      if (film == null) {
        return NotFound();
      }
      return Ok(film);
    }
  }
}