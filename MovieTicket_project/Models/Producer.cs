using System.ComponentModel.DataAnnotations;

namespace MovieTicket_project.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Bio { get; set; }
        
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
