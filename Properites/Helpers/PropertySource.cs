using Properites.Models;

namespace Properites.Helpers;
public static class PropertySource
{
    public static List<Property> Properties { get; } = new List<Property>
    {
        new Property
        {
            ID = 1,
            Title = "Stunning Modern Apartment in the Heart of Downtown",
            Thumbnail = "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_0.webp",
            Photos = new List<string>
            {
                "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_0.webp",
                "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_2.webp",
                "https://cdn.midjourney.com/13bf3578-0806-4a98-8343-f951c548cf04/0_0.webp"
            },
            Location = "123 Main St, Anytown, USA",
            SquareMeters = 85,
            Description = "Experience luxury living in this breathtaking modern apartment situated in the heart of downtown. With sleek finishes, open-concept living spaces, and floor-to-ceiling windows offering stunning city views, this apartment is the epitome of urban sophistication. Enjoy the convenience of being just steps away from top-rated restaurants, shops, and entertainment venues. Don't miss this opportunity to make this incredible apartment your new home!",
            Latitude = 40.7128,
            Longitude = -74.0060
        },
        new Property
        {
            ID = 2,
            Title = "Charming Cottage Nestled in a Serene Woodland Setting",
            Thumbnail = "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_0.webp",
            Photos = new List<string>
            {
                "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_0.webp",
                "https://cdn.midjourney.com/f1a3f606-436f-438f-9787-9130ab0aea44/0_2.webp",
                "https://cdn.midjourney.com/13bf3578-0806-4a98-8343-f951c548cf04/0_0.webp"
            },
            Location = "456 Elm St, Countryside, USA",
            SquareMeters = 120,
            Description = "Escape to this enchanting cottage tucked away in a tranquil woodland setting. With its cozy interior, rustic charm, and beautiful garden, this property offers the perfect retreat from the hustle and bustle of everyday life. Enjoy peaceful mornings sipping coffee on the porch, and spend your days exploring the nearby hiking trails and quaint local shops. This cottage is the ideal getaway for those seeking a slice of paradise.",
            Latitude = 37.7749,
            Longitude = -122.4194
        },
        // Additional properties will be added here...
    };
}
