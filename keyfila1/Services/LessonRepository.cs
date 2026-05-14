using System.Collections.Generic;
using System.Linq;
using Dapper;
using keyfila1.Models;

namespace keyfila1.Services
{
    public static class LessonRepository
    {
        private static List<Level> _levels;

        public static List<Level> GetLevels()
        {
            if (_levels == null) LoadFromDatabase();
            return _levels;
        }

        public static void LoadFromDatabase()
        {
            const string sql = "SELECT * FROM Lessons ORDER BY Id";
            
            using (var db = DatabaseService.GetConnection())
            {
                var allLessons = db.Query<Lesson>(sql).ToList();
                
                if (!allLessons.Any())
                {
                    SeedDatabase();
                    allLessons = db.Query<Lesson>(sql).ToList();
                }

                _levels = allLessons
                    .GroupBy(l => (Difficulty)l.Difficulty)
                    .Select(g => {
                        var level = new Level 
                        { 
                            Difficulty = g.Key,
                            Lessons = g.ToList() 
                        };
                        
                        // Set descriptions
                        switch (level.Difficulty)
                        {
                            case Difficulty.Beginner: level.Description = "Master the home row and basic finger placement."; break;
                            case Difficulty.Intermediate: level.Description = "Common words and muscle memory building."; break;
                            case Difficulty.Advanced: level.Description = "Complex sentences, symbols, and high-speed practice."; break;
                        }
                        return level;
                    }).ToList();
            }
        }

        public static Lesson GetNextLesson(int currentId)
        {
            var allLessons = GetLevels().SelectMany(l => l.Lessons).Where(l => !l.IsHeader).ToList();
            var index = allLessons.FindIndex(l => l.Id == currentId);
            if (index >= 0 && index < allLessons.Count - 1)
            {
                return allLessons[index + 1];
            }
            return null;
        }

        public static Lesson GetPreviousLesson(int currentId)
        {
            var allLessons = GetLevels().SelectMany(l => l.Lessons).Where(l => !l.IsHeader).ToList();
            var index = allLessons.FindIndex(l => l.Id == currentId);
            if (index > 0)
            {
                return allLessons[index - 1];
            }
            return null;
        }

        private static void SeedDatabase()
        {
            // This is a safety method to populate the DB if it's empty
            var initialLessons = new List<Lesson>
            {
                new Lesson { Id = 1, Title = "J and F: Introduction", Content = "j f j f j f j f jjj fff jjj fff jf fj jf fj jjjj ffff" },
                new Lesson { Id = 2, Title = "J and F: Patterns", Content = "jf jf fj fj jff jff fjj fjj jjf fjj jfj fjf fff jjj fff jjj" },
                new Lesson { Id = 3, Title = "Space Bar: Basics", Content = "j f j f j f j f jj ff jj ff j f j f jf fj jf fj j f j f" },
                // ... we can add more here or let the user run the SQL script
            };

            const string sql = @"
                INSERT INTO Lessons (Id, Title, Content, Difficulty, IsHeader) 
                VALUES (@Id, @Title, @Content, @Difficulty, @IsHeader)";

            using (var db = DatabaseService.GetConnection())
            {
                db.Execute(sql, initialLessons);
            }
        }
    }
}
