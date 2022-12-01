using eTickets_Project.Data;
using eTickets_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets_Project.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Cinema> cinemas = _context.Cinemas.ToList();
            return View(cinemas);
        }
    }
}
