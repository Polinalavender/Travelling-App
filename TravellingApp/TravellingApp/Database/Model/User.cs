using SQLite;


namespace TravellingApp.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("user")]
    public class User
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
    }
}
