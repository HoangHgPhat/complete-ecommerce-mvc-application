using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket_project.Data;
using MovieTicket_project.Models;

namespace MovieTicket_project.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Actors.ToListAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            
            if (ModelState.IsValid)
            {
                _context.Actors.Add(actor);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        //Get: Actors/Details/1(id)
        public async Task<IActionResult> Details(int id)
        {
            // return the actor with id parameter
            var actorDetails = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get: Actors/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            // return the actor with id parameter
            var actorDetails = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Actor actor)
        {

            if (ModelState.IsValid)
            {
                _context.Update(actor);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        //Get: Actors/Edit
        public async Task<IActionResult> Delete(int id)
        {
            // return the actor with id parameter
            var actorDetails = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            if (actorDetails == null) return View("NotFound");

            _context.Actors.Remove(actorDetails);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
