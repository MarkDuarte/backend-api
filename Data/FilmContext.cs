using System;
using film_api.Models;
using Microsoft.EntityFrameworkCore;

namespace film_api.Data
{
	public class FilmContext : DbContext
	{
		public FilmContext(DbContextOptions<FilmContext> opts) : base(opts)
		{
			
		}

		public DbSet<Film> Films { get; set; }
	}
}

