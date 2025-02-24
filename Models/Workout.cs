using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerApp.Models
{
    public class Workout
    {
        public int Id { get; set; }

        public required string UserId { get; set; }

        public required DateTime Date { get; set; } = DateTime.Now;

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}