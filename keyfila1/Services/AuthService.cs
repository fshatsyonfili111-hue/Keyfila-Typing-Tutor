using System;
using System.Linq;
using MySqlConnector;
using Dapper;
using keyfila1.Models;

namespace keyfila1.Services
{
    public static class AuthService
    {
        public static User Login(string username, string password)
        {
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                const string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                return db.QuerySingleOrDefault<User>(sql, new { Username = username, Password = password });
            }
        }

        public static bool Register(string username, string password, string question, string answer)
        {
            try
            {
                using (var db = DatabaseService.GetConnection())
                {
                    db.Open();
                    const string sql = "INSERT INTO Users (Username, Password, SecurityQuestion, SecurityAnswer) VALUES (@Username, @Password, @Question, @Answer)";
                    db.Execute(sql, new { Username = username, Password = password, Question = question, Answer = answer });
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetSecurityQuestion(string username)
        {
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                return db.QuerySingleOrDefault<string>("SELECT SecurityQuestion FROM Users WHERE Username = @Username", new { Username = username });
            }
        }

        public static bool ResetPassword(string username, string answer, string newPassword)
        {
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                const string sql = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username AND SecurityAnswer = @Answer";
                int rows = db.Execute(sql, new { Username = username, Answer = answer, NewPassword = newPassword });
                return rows > 0;
            }
        }
        public static bool UpdateUsername(int userId, string currentPassword, string newUsername)
        {
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                // Verify current password first
                int count = db.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Users WHERE Id = @Id AND Password = @Password",
                    new { Id = userId, Password = currentPassword });
                if (count == 0) return false;

                // Check new username not taken
                int taken = db.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Id != @Id",
                    new { Username = newUsername, Id = userId });
                if (taken > 0) return false;

                db.Execute("UPDATE Users SET Username = @Username WHERE Id = @Id",
                    new { Username = newUsername, Id = userId });
                return true;
            }
        }

        public static bool UpdatePassword(int userId, string currentPassword, string newPassword)
        {
            using (var db = DatabaseService.GetConnection())
            {
                db.Open();
                int rows = db.Execute(
                    "UPDATE Users SET Password = @New WHERE Id = @Id AND Password = @Current",
                    new { New = newPassword, Id = userId, Current = currentPassword });
                return rows > 0;
            }
        }
    }
}
