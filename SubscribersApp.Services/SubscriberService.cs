using Subscribers.Infrastructure.Contract;
using SubscribersApp.Domain.Contracts;
using SubscribersApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Services
{
    public class SubscriberService : ISubscriberService
    {
        public readonly IRepository<Subscriber> _subscriberRepository;

        public SubscriberService(IRepository<Subscriber> subscriberRepository)
        {
            this._subscriberRepository = subscriberRepository;
        }
        public void Delete(Subscriber entity)
        {
            throw new NotImplementedException();
        }

        public IList<Subscriber> GetAll()
        {
            return _subscriberRepository.Get();
        }

        public Subscriber GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Subscriber Insert(Subscriber entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Subscriber entity)
        {
            throw new NotImplementedException();
        }
    }
}
