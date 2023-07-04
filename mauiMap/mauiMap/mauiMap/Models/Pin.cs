using System;
using Microsoft.EntityFrameworkCore;
using mauiMap.Models;

namespace mauiMap.Models
{
	public class Pin
	{
        public int Id { get; set; } //to have some sort of identification
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}

