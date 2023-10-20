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
    public void AddFilm([FromBody]Film film) {
      film.Id = id++;
      films.Add(film);
      Console.WriteLine(film.Title);
      Console.WriteLine(film.Genere);
      Console.WriteLine(film.Duraction);
    }

    [HttpGet]
    public IEnumerable<Film> getFilms([FromQuery] int skip = 0, [FromQuery] int take = 50) {
      return films.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public Film? getFilm(int id) {
      return films.FirstOrDefault(film => film.Id == id);
    }
  }
}