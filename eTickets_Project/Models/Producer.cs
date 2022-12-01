using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTickets_Project.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships  Producer can have many movies 
        public ICollection<Movie>? Movies { get; set; }
    }
}
