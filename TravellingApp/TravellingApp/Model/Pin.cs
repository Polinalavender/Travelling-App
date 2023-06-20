using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
