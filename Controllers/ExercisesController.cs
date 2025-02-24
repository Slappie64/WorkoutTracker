using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTrackerApp.Data;
using WorkoutTrackerApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace WorkoutTrackerApp.Controllers
{
    [Authorize]
    public class ExercisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExercisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Exercises/Create?workoutId=5
        public IActionResult Create(int workoutId)
        {
            var exercise = new Exercise { WorkoutId = workoutId };
            return View(exercise);
        }

        // POST: Exercises/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkoutId,Name,Sets,Reps,Weight")] Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exercise);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Workouts", new {id = exercise.WorkoutId});
            }
            return View(exercise);
        }

        // Implement other actions if necessary (Edit, Delete)
    }
}