﻿namespace BullsAndCows.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using Models;
    using Repositories;

    public class BullsAndCowsData : IBullsAndCowsData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public BullsAndCowsData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
           
        }

        public IRepository<Game> Games
        {
            get
            {
                return this.GetRepository<Game>();
            }
           
        }

        public IRepository<Guess> Guesses
        {
            get
            {
                return this.GetRepository<Guess>();
            }
            
        }

        public IRepository<Notification> Notifications
        {
            get
            {
                return this.GetRepository<Notification>();
            }
           
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T: class 
        {
            var typeOfRepository = typeof (T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof (BaseRepository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }
    }
}
