using MovieTicket_project.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicket_project.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<ActorMovie> ActorsMovies { get; set; }
        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("CinemaId")]
        public Producer Producer { get; set; }
    }
}
