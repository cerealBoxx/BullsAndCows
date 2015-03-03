namespace BullsAndCows.Data
{
    using Models;
    using Repositories;

    public interface IBullsAndCowsData
    {
        IRepository<ApplicationUser> Users { get; }
        IRepository<Game> Games { get; }
        IRepository<Guess> Guesses { get;  }
        IRepository<Notification> Notifications { get; }

        int SaveChanges();
    }
}
