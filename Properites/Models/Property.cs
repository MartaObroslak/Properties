using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Properites.Models
{
    public class PropertyContext : DbContext
    {
        public PropertyContext(DbContextOptions<PropertyContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Photo> Photos { get; set; } 
    }

    public class Property
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        public byte[]? Thumbnail { get; set; }

        public List<Photo>? Photos { get; set; } 

        [Required(ErrorMessage = "Square Meters are required")]
        public int SquareMeters { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        public float Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required")]
        public float Longitude { get; set; }
    }

    public class Photo
    {
        public int ID { get; set; }
        public byte[]? ImageData { get; set; }
        public Property? Property { get; set; } 
    }
}
