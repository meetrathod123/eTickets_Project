using eTickets_Project.Data;
using eTickets_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_Project.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Movie> movies = _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToList();
            return View(movies);
        }
    }
}
