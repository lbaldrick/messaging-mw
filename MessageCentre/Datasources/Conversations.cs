using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageCentre.Models;
using MongoDB.Driver;

namespace MessageCentre.Datasources
{
    public class Conversations : IDatasource<Conversation>
    {
        private IMongoDatabase Client;

        public Conversations(IMongoDatabase client)
        {
            this.Client = client;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Conversation t)
        {
            throw new NotImplementedException();
        }

        public Conversation Retrieve(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Conversation t)
        {
            throw new NotImplementedException();
        }
    }
}
