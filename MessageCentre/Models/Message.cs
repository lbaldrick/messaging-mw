using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageCentre.Models
{
    public class Message
    {
        private string IdFrom { get; }
        private long Timestamp { get; }
        private string Body { get; }
        private string ConversationId { get; }

        public Message(string idFrom, long timestamp, string body, string conversationId)
        {
            this.IdFrom = idFrom;
            this.Timestamp = timestamp;
            this.Body = body;
            this.ConversationId = conversationId;
        }
    }
}
