using Microsoft.AspNetCore.Identity;

namespace ReunGroopWebApp.Models
{
    public class AppUser : IdentityUser
    {
        //Para las variables con signo de ? en el tipo de dato int?, bool? refiere a que puede tener valores nullos.
        public int? Pace { get; set; }

        public int? Mileage { get; set; }
        public Address Address { get; set; }

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
