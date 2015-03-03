namespace BullsAndCows.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public ICollection<Notification> Notifications { get; set; }

        public ApplicationUser()
        {
            this.Notifications = new HashSet<Notification>();
        }

        public int Wins { get; set; }
        public int Losses { get; set; }

        [NotMapped]
        public int Rank
        {
            get
            {
                return this.Wins * 100 + this.Losses * 15;
            }
        }

        
    }
}
