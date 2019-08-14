using SubscribersApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Domain.Entities
{
    public class Subscriber: Entity
    {
        public string Name { get; set; }
        public SubscriberType SubscriberType { get; set; }
    }
}
