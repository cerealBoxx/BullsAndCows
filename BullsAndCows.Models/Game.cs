namespace BullsAndCows.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public Game()
        {
            this.Id = new Guid();
            this.State = GameState.WaitingForSecondPlayer;
            this.Guesses = new HashSet<Guess>();
        }
        public Guid Id { get; set; }

        public GameState State { get; set; }

        public ICollection<Guess> Guesses { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        
        [Required]
        public string RedPlayerId { get; set; }
        public virtual ApplicationUser RedPlayer { get; set; }

        public string BluePlayerID { get; set; }
        public virtual ApplicationUser BluePlayer { get; set; }

        [Required]
        public string FirstPlayerNumber { get; set; }

        public string SecondPlayerNumber { get; set; }
    }
}
