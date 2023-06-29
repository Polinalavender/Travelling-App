using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TravellingApp.Model;

namespace TravellingApp.Data
{
    public class DataRepo
    {
            public string _dbPath;
            private SQLiteConnection conn;

            public DataRepo(string dbPath)
            {
                _dbPath = dbPath;
            }

            public void CreateTables()
            {
                try
                {
                    conn = new SQLiteConnection(_dbPath);
                    conn.CreateTable<Trip>();
                    conn.CreateTable<User>();
                    conn.CreateTable<Pin>();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            internal void Add(Trip trip)
            {
                conn = new SQLiteConnection(_dbPath);
                conn.CreateTable<Trip>();
                conn.Insert(trip);
            }
            internal void Add(User user)
            {
                conn = new SQLiteConnection(_dbPath);
                conn.CreateTable<User>();
                conn.Insert(user);
            }
            internal void Add(Pin mapPin)
            {
                conn = new SQLiteConnection(_dbPath);
                conn.CreateTable<Pin>();
                conn.Insert(mapPin);
            }

            public List<Trip> GetAllTrips()
            {
                try
                {
                CreateTables();
                    return conn.Table<Trip>().ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new List<Trip>();
            }

            public Trip GetTripById(int tripId)
            {
                try
                {
                CreateTables();
                    return conn.Table<Trip>().FirstOrDefault(t => t.Id == tripId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
            public User GetUserById(int userId)
            {
                try
                {
                CreateTables();
                    return conn.Table<User>().FirstOrDefault(t => t.Id == userId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
        public User GetUserByName(string name)
        {
            try
            {
                CreateTables();
                return conn.Table<User>().FirstOrDefault(t => t.Username == name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public User GetUserByEmail(string email)
        {
            try
            {
                CreateTables();
                return conn.Table<User>().FirstOrDefault(t => t.UserEmail == email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public Pin GetMapPinById(int pinId)
            {
                try
                {
                CreateTables();
                    return conn.Table<Pin>().FirstOrDefault(t => t.Id == pinId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
            internal void Delete(int id)
            {
                conn = new SQLiteConnection(_dbPath);
                conn.Delete(new Trip { Id = id });
            }
        }
}
