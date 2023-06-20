using SQLite;

namespace TravellingApp.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("trip")]
    public class Trip
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
            public int Id { get; set; }
            public string Location { get; set; }
            public string Name { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public string TravelType { get; set; }
            public string ImagePath { get; set; }
        }
    }