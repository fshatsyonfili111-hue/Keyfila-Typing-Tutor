using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using keyfila1.Models;
using keyfila1.Services;

namespace keyfila1.Models
{
    public class UserProgressRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public int WPM { get; set; }
        public double Accuracy { get; set; }
        public int Errors { get; set; }
        public int Stars { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}

namespace keyfila1.Services
{
    public static class UserProgressRepository
    {
        public static void SaveProgress(int userId, int lessonId, TypingStats stats)
        {
            const string getLessonSql = "SELECT ExpectedWPM FROM Lessons WHERE Id = @Id";
            const string insertSql = @"
                INSERT INTO UserProgress (UserId, LessonId, WPM, Accuracy, Errors, Stars)
                VALUES (@UserId, @LessonId, @WPM, @Accuracy, @Errors, @Stars)";

            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                int expectedWpm = db.ExecuteScalar<int>(getLessonSql, new { Id = lessonId });
                
                // Dynamic star calculation based on lesson goal
                int stars = 0;
                if (stats.Accuracy >= 98 && stats.WPM >= expectedWpm) stars = 3;
                else if (stats.Accuracy >= 90 && stats.WPM >= (expectedWpm * 0.7)) stars = 2;
                else if (stats.Accuracy >= 80) stars = 1;

                db.Execute(insertSql, new
                {
                    UserId = userId,
                    LessonId = lessonId,
                    WPM = stats.WPM,
                    Accuracy = stats.Accuracy,
                    Errors = stats.Errors,
                    Stars = stars
                });
            }
        }

        public static List<UserProgressRecord> GetProgressForUser(int userId)
        {
            const string sql = "SELECT * FROM UserProgress WHERE UserId = @UserId ORDER BY CompletedAt DESC";
            
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                return db.Query<UserProgressRecord>(sql, new { UserId = userId }).ToList();
            }
        }

        public static int GetBestStarsForLesson(int userId, int lessonId)
        {
            const string sql = "SELECT MAX(Stars) FROM UserProgress WHERE UserId = @UserId AND LessonId = @LessonId";
            
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                return db.ExecuteScalar<int>(sql, new { UserId = userId, LessonId = lessonId });
            }
        }
    }
}
