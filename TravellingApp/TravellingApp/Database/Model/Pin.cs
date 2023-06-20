using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravellingApp.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("pin")]
    public class Pin
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
        public int Id { get; set; }

        [ForeignKey("trip")]
        public int TripId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}

