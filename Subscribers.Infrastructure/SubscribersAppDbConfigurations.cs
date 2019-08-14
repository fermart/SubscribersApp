using SubscribersApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribers.Infrastructure
{
    public class SubscriberConfiguration : EntityTypeConfiguration<Subscriber>
    {
        public SubscriberConfiguration()
        {
            this.Property(x => x.Name).IsRequired().HasMaxLength(80);
        }
    }
}
