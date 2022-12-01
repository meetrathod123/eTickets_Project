using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace eTickets_Project.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 to 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships Actor can have many movies from common model table
        [NotMapped]
        public ICollection<Actor_Movie> Actors_Movies { get; set; }
    }
}
