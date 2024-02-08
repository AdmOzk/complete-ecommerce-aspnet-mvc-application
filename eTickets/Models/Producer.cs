using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }


        //Relationships

        public List<Movie> Movies { get; set; }




    }
}
