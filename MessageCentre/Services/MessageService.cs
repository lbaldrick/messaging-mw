using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageCentre.Datasources;
using MessageCentre.Models;

namespace MessageCentre.Services
{
    public class MessageService : IMessageService
    {
        readonly IDatasource<Conversation> Conversations;

        public MessageService(IDatasource<Conversation> conversations)
        {
            this.Conversations = conversations;
        }

        public bool InsertMessage(string id, string message)
        {
            throw new NotImplementedException();
        }

        public bool DeleteConversationById(string id)
        {
            throw new NotImplementedException();
        }

        public Conversation GetConversationById(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateConversation(string id, Conversation conversation)
        {
            throw new NotImplementedException();
        }
    }
}
