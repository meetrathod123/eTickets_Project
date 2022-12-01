using eTickets_Project.Data;
using eTickets_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets_Project.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Producer> producers = _context.Producers.ToList();
            return View(producers);
        }
    }
}
