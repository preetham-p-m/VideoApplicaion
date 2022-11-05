using Microsoft.AspNetCore.Mvc;
using VSR.Models;
using VSR.ViewModel.Movies;

namespace VSR.Controllers
{
    public class MoviesController : Controller
    {

        private MyDbContext _context;

        public MoviesController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Index Page
        public ViewResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        // Movie Detail Page
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return Content("Page not found");

            return View(movie);

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
