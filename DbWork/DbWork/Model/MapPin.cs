using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbWork.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("mappin")]
    public class MapPin
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
        public int Id { get; set; }
        public Trip Trip { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
