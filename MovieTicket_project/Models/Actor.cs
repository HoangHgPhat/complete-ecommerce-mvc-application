using System.ComponentModel.DataAnnotations;

namespace MovieTicket_project.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<ActorMovie> ActorsMovies { get; set; }
    }
}
