using System.Collections.Generic;

namespace keyfila1.Models
{
    public enum Difficulty
    {
        Beginner,
        Intermediate,
        Advanced
    }

    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Difficulty { get; set; } // Added this to fix build error
        public int ExpectedWPM { get; set; }
        public bool IsHeader { get; set; }
        public bool IsStarted { get; set; }
        public int AvgSpeed { get; set; }
        public int AvgAccuracy { get; set; }
        public string BestTime { get; set; }
    }

    public class Level
    {
        public Difficulty Difficulty { get; set; }
        public string Description { get; set; }
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
