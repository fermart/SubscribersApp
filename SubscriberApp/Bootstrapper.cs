﻿using Subscribers.Infrastructure;
using Subscribers.Infrastructure.Contract;
using SubscribersApp.Domain.Contracts;
using SubscribersApp.Domain.Entities;
using SubscribersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace SubscriberApp
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>), new TransientLifetimeManager());
            container.RegisterType(typeof(ISubscriberService), typeof(SubscriberService), new TransientLifetimeManager());
        }
    }
}