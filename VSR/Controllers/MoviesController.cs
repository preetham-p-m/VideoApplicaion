using Microsoft.AspNetCore.Mvc;
using VSR.Models;

namespace VSR.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name="Shrek" };
            return View(movie);
        }
    }
}
