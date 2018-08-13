using MessageCentre.Datasources;
using MessageCentre.Models;
using MessageCentre.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageCentre.Cache
{
    public class ConversationCache : ICache<Conversation, string>
    {
        readonly IDatasource<Conversation> Conversations;
        readonly Dictionary<string, ConversationWrapper> ConversationMap;

        public ConversationCache(IDatasource<Conversation> Conversations)
        {
            this.Conversations = Conversations;
            ConversationMap = new Dictionary<string, ConversationWrapper>();
        }

        public int Count()
        {
            return this.ConversationMap.Count();
        }

        public bool DeleteEntry(string key)
        {
          
            this.ConversationMap.Remove(key);
            Conversations.Delete(key);

            //TODO fix this
            return true;
        }

        public Conversation GetEntry(string key)
        {
            ConversationWrapper value = null;
            
            if (this.ConversationMap.TryGetValue(key, out value))
            {
                return value.Conversation;
            }

            Conversation conversation = Conversations.Retrieve(key);

            this.ConversationMap.Add(conversation.Id, new ConversationWrapper(conversation, DateTimeOffset.UtcNow.ToUnixTimeSeconds()));

            return conversation;
        }

        public void InsertEntry(Conversation entry)
        {
            ConversationWrapper newConversation = new ConversationWrapper(entry, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            if (this.ConversationMap.ContainsKey(entry.Id))
            {
                foreach (KeyValuePair<string, ConversationWrapper> conversation in this.ConversationMap)
                {
                    if (conversation.Key.Equals(entry.Id))
                    {
                        this.ConversationMap[conversation.Key] = newConversation;
                        break;
                    }
                }
            } else
            {
                this.ConversationMap.Add(entry.Id, newConversation);
            }
           
            this.Conversations.Insert(entry);
        }
    }

    class ConversationWrapper
    {
        public Conversation Conversation { get; }
        public Int64 LastAccessedTimestamp { get; }

        public ConversationWrapper(Conversation Conversation, Int64 LastAccessedTimestamp)
        {
            this.Conversation = Conversation;
            this.LastAccessedTimestamp = LastAccessedTimestamp;
        }
    }
}
