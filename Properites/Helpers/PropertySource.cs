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
            Thumbnail = "https://agnesinversiones.com/photo/apartament-na-sprzedaz-3-sypialnie-benahavis-ai-aa-121-2023/77030783.jpg",
            Photos = new List<string>
            {
                "https://agnesinversiones.com/photo/apartament-na-sprzedaz-3-sypialnie-benahavis-ai-aa-121-2023/77030785.jpg",
                "https://agnesinversiones.com/photo/apartament-na-sprzedaz-3-sypialnie-benahavis-ai-aa-121-2023/77030787.jpg",
                "https://agnesinversiones.com/photo/apartament-na-sprzedaz-3-sypialnie-benahavis-ai-aa-121-2023/77030789.jpg",
                "https://agnesinversiones.com/photo/apartament-na-sprzedaz-3-sypialnie-benahavis-ai-aa-121-2023/77030791.jpg"
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
                "https://cdn.midjourney.com/13bf3578-0806-4a98-8343-f951c548cf04/0_0.webp",
                "https://cdn.midjourney.com/13bf3578-0806-4a98-8343-f951c548cf04/0_0.webp"

            },
            Location = "456 Elm St, Countryside, USA",
            SquareMeters = 120,
            Description = "Indulge in the ultimate urban lifestyle with this remarkable modern apartment nestled in the bustling downtown district. Showcasing sophisticated design elements, expansive living areas, and panoramic city vistas through floor-to-ceiling windows, this residence exudes metropolitan charm. Embrace the ease of access to acclaimed eateries, designer boutiques, and entertainment hotspots just steps from your door. Make this exceptional apartment your sanctuary in the heart of the city!",
            Latitude = 37.7749,
            Longitude = -122.4194
        },
        new Property
        {
            ID = 3,
            Title = "Luxury villa located by the sea",
            Thumbnail = "https://goeste.pl/wp-content/uploads/2023/06/1669461979.webp",
            Photos = new List<string>
            {
                "https://goeste.pl/wp-content/uploads/2024/02/10555.1.93j-04-sn-1024x527.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/14522.1.vapf_45-45j_int_hq_220218_08-sn.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/10567.1.img_7526-b-sn-1024x683.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/10563.1.93j-06-sn-1024x527.jpg"
            },
            Location = "Avenida del Parque 23, Madrid, Spain",
            SquareMeters = 120,
            Description = "Escape to this enchanting cottage tucked away in a tranquil woodland setting. With its cozy interior, rustic charm, and beautiful garden, this property offers the perfect retreat from the hustle and bustle of everyday life. Enjoy peaceful mornings sipping coffee on the porch, and spend your days exploring the nearby hiking trails and quaint local shops. This cottage is the ideal getaway for those seeking a slice of paradise.",
            Latitude = 57.7749,
            Longitude = -172.4194
        },
        new Property
        {
            ID = 4,
            Title = "VILLAS W CUMBRE DEL SOL",
            Thumbnail = "https://goeste.pl/wp-content/uploads/2024/02/14873.1.vafp_aj241_hq_day_220909_01-sn-1024x576.jpg",
            Photos = new List<string>
            {
                "https://goeste.pl/wp-content/uploads/2024/02/14877.1.vafp_aj241_hq_day_220909_04-sn-1024x576.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/14881.1.vafp_aj241_hq_int_220909_00-sn-1024x576.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/14897.1.vafp_aj241_hq_night_220909_02-sn-1024x576.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/14901.1.vafp_aj241_hq_night_220909_03-sn-1024x576.jpg"
            },
            Location = "456 Oak Street, Countryside, Spain",
            SquareMeters = 140,
            Description = "Immerse yourself in the epitome of luxury living with this stunning contemporary apartment located in the vibrant heart of the city. Boasting elegant touches, expansive open-plan areas, and panoramic windows framing breathtaking urban vistas, this residence defines urban chic. Revel in the convenience of being mere moments away from premier dining spots, boutiques, and cultural attractions. Seize the chance to transform this remarkable apartment into your own urban oasis!",
            Latitude = 37.7749,
            Longitude = -122.4194
        },
        new Property
        {
            ID = 5,
            Title = "Villa in Mar de Pulpi, Costa Almeria",
            Thumbnail = "https://goeste.pl/wp-content/uploads/2024/02/d13193-1-1024x576.jpg",
            Photos = new List<string>
            {
                "https://goeste.pl/wp-content/uploads/2024/02/d11498-1.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/d13190-1-1024x576.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/d13192-1-1024x576.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/12801.1.39j_vapf_int_hq_191204__02-sn.jpg"
            },
            Location = "Calle del Bosque 15, Valencia, Spain",
            SquareMeters = 105,
            Description = "Elevate your urban experience with this exquisite contemporary apartment located in the pulsating center of downtown. Featuring refined finishes, spacious layouts, and sweeping city panoramas from every angle, this home epitomizes modern elegance. Delight in the proximity to acclaimed dining establishments, upscale shops, and cultural attractions within walking distance. Seize the opportunity to call this exceptional apartment your own urban retreat!.",
            Latitude = 66.7749,
            Longitude = -22.4194
        },
        new Property
        {
            ID = 6,
            Title = "Villas in Cumbre del Sol, Alicante, Spain",
            Thumbnail = "https://goeste.pl/wp-content/uploads/2024/02/12772.1.39j_vapf_night_hq_191204_00-sn.jpg",
            Photos = new List<string>
            {
                "https://goeste.pl/wp-content/uploads/2024/02/12781.1.39j_vapf_day_hq_191204_00-sn.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/12785.1.39j_vapf_day_hq_191204_01-sn.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/12793.1.39j_vapf_int_hq_191204__00-sn.jpg",
                "https://goeste.pl/wp-content/uploads/2024/02/12797.1.39j_vapf_int_hq_191204__01-sn.jpg"
            },
            Location = "Paseo de la Playa 42, Malaga, Spain",
            SquareMeters = 120,
            Description = "Immerse yourself in the essence of urban sophistication with this breathtaking modern apartment ideally situated in downtown's dynamic core. With stylish touches, expansive living areas, and unparalleled city views through floor-to-ceiling windows, this residence sets the standard for contemporary living. Embrace the convenience of having top-notch restaurants, boutiques, and entertainment venues just moments away. Don't let this chance slip by to claim this remarkable apartment as your urban sanctuary!",
            Latitude = 38.7756,
            Longitude = -162.4194
        },




    };
}
