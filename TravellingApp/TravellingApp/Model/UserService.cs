using System;
using TravellingApp.Model;
using SQLite;

namespace TravellingApp.Services
{
    public class UserService
    {
        private SQLiteConnection database;

        public UserService(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<User>();
        }

        public bool RegisterUser(string username, string password)
        {
            // Check if the username already exists
            bool usernameExists = database.Table<User>().Any(u => u.Username == username);

            if (usernameExists)
            {
                // Username already taken
                return false;
            }

            // Create a new User instance
            User newUser = new User
            {
                Username = username,
                Password = password
            };

            // Insert the new user into the database
            int rowsAffected = database.Insert(newUser);

            // Check if the user was successfully inserted
            bool isRegistered = rowsAffected > 0;

            return isRegistered;
        }
    }
}
