using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }



        public async Task<IActionResult> Index()
        {

            var allMovies = await _service.GetAllAsync(n => n.Cinema);

            return View(allMovies);
        }

        //GET: Movies/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        public ActionResult Create()

        {

            ViewData["Welcome"] = "Welcome to our store";
            ViewBag.Description = "This is store description";

            return View();
        }

    }
}
