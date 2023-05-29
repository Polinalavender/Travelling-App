using DbWork.Model;
using SQLite;


namespace DbWork.Data
{
    public class DataRepo
    {
        string _dbPath;
        private SQLiteConnection conn;

        public DataRepo(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void CreateTable()
        {
            try
            {
                conn = new SQLiteConnection(_dbPath);
                conn.CreateTable<Trip>();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal void Add(Trip trip)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(trip);
        }

        public List<Trip> GetAllTrips()
        {
            try
            {
                CreateTable();
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
                CreateTable();
                return conn.Table<Trip>().FirstOrDefault(t => t.Id == tripId);
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