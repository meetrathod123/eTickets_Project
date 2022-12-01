using eTickets_Project.Data;
using eTickets_Project.Interfaces;
using eTickets_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets_Project.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsRepository _actorsRepository;
        public ActorsController(IActorsRepository actorsRepository)
        {
            _actorsRepository = actorsRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Actor> actors = await _actorsRepository.GetAllAsync();
            return View(actors);
        }
         public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsRepository.AddAsync(actor);
            return RedirectToAction("Index");

        }
        public async Task<ActionResult> Details(int id)
        {
            var actorDetails = await _actorsRepository.GetByIDAsync(id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsRepository.GetByIDAsync(id);
            if (actorDetails == null) return View("Not Found"); 
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsRepository.UpdateAsync(id, actor);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsRepository.GetByIDAsync(id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsRepository.GetByIDAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            await _actorsRepository.DeleteAsync(id);
            return RedirectToAction("Index");

        }
    }
}
