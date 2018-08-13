using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageCentre.Models
{
    public class Conversation
    {
        public ISet<string> AttendeeIds { get; }
        public IList<Message> Messages { get; }
        public string Id { get; }

        public Conversation(string id, ISet<string> attendeeIds, IList<Message> messages)
        {
            this.AttendeeIds = attendeeIds;
            this.Messages = messages;
            this.Id = Id;
        }
    }
}
