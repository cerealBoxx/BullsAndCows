using System;
namespace BullsAndCows.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Guess
    {
        public int Id { get; set; }
        [StringLength(4)]
        [Required]
        public string Number { get; set; }

        public string PlayerId { get; set; }
        public virtual ApplicationUser Player { get; set; }

        public string GameId { get; set; }
        public virtual Game Game { get; set; }

        public int NumberOfBulls { get; set; }
        public int NumberOfCows { get; set; }
    }
}
