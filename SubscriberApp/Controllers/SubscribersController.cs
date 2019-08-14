using SubscribersApp.Domain.Contracts;
using SubscribersApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SubscriberApp.Controllers
{
    public class SubscribersController : ApiController
    {
        private readonly ISubscriberService _subscriberService;

        public SubscribersController(ISubscriberService subscriberService)
        {
            this._subscriberService = subscriberService;
        }

        // GET: api/Subscribers
        public IHttpActionResult Get()
        {
            return Ok(new { results = _subscriberService.GetAll() });
        }

        // GET: api/Subscribers/5
        public IHttpActionResult Get(int id)
        {
            return Ok(new { results = _subscriberService.GetById(id) });
        }

        // POST: api/Subscribers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subscribers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subscribers/5
        public void Delete(int id)
        {
        }
    }
}
