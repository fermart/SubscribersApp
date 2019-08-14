using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SubscribersApp.Domain.Entities;

namespace Subscribers.Infrastructure
{
    public class SubscribersAppContext: DbContext
    {
        public SubscribersAppContext() : base("SubscribersContext")
        {
            Database.SetInitializer<SubscribersAppContext>(new SubscribersAppDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SubscriberConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}
