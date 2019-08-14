namespace Subscribers.Infrastructure.Migrations
{
    using SubscribersApp.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Subscribers.Infrastructure.SubscribersAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Subscribers.Infrastructure.SubscribersAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Subscribers.Add(new Subscriber() { Name = "Lucas Zanek", SubscriberType = SubscribersApp.Domain.Enum.SubscriberType.Individual });
            context.Subscribers.Add(new Subscriber() { Name = "Southworks", SubscriberType = SubscribersApp.Domain.Enum.SubscriberType.Company });

        }
    }
}
