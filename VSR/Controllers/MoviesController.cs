using Microsoft.AspNetCore.Mvc;
using VSR.Models;
using VSR.ViewModel.Movies;

namespace VSR.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // Random Movie Page
        public ActionResult Random()
        {
            var movie = new Movie{ Name="F1" };
            var customers = new List<Customer>
            {
                new Customer{Name="C1" },
                new Customer{Name="C2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };
            return View(viewModel);
        }

    }
}
