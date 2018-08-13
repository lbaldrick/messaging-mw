using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageCentre.Models;

namespace MessageCentre.Services
{
    public interface IMessageService
    {
        Conversation GetConversationById(string id);

        bool InsertMessage(string id, string message);

        bool DeleteConversationById(string id);

        bool UpdateConversation(string id, Conversation conversation);

    }
}
