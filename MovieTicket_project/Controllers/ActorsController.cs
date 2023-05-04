using Microsoft.AspNetCore.Mvc;
using MovieTicket_project.Data;

namespace MovieTicket_project.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
