namespace BullsAndCows.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification
    {
         public int Id { get; set; }
         public NotificationState State { get; set; }

         public string Message { get; set; }

         [Required]
         public DateTime DateCreated { get; set; }

         public string PlayerId { get; set; }
         public virtual ApplicationUser Player { get; set; }

         public bool IsRead { get; set; }

         public int GameId { get; set; }

         public virtual Game Game { get; set; }
    }
}
