using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MessageCentre.Datasources;
using MessageCentre.Models;
using MessageCentre.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace MessageCentre
{
    public static class AppRegistry
    {

       public static void  Register(WindsorContainer container)
        {

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("messages");

            container.Register(Component.For<IDatasource<Conversation>>().ImplementedBy<Conversations>());
            container.Register(Component.For<IMessageDao>().ImplementedBy<MessageService>());
            container.Register(Component.For<IMongoDatabase>().Instance(database));
        }

    }
}
