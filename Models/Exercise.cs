using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerApp.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required]
        public required int WorkoutId { get; set; }

        public Workout Workout { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public  int Sets { get; set; }

        [Required]
        public int Reps { get; set; }

        public double Weight { get; set; }
    }
}