using System;
using System.Collections.Generic;
using System.Linq;

namespace WStock.Framework.Models
{
    public class Messages
    {
        private List<Message> ListMessages { get; set; }
        public Messages()
        {
            ListMessages = new List<Message>();
        }
        public void Add(string Description)
        {
            ListMessages.Add(new Message(Description));
        }
        public void Add(string Code, string Title, string Description)
        {
            ListMessages.Add(new Message(Code, Title, Description));
        }
        public void AddRange(List<Message> ListMessages)
        {
            ListMessages.AddRange(ListMessages);
        }
        public int Count()
        {
            return ListMessages.Count;
        }
        public List<Message> ToList()
        {
            return ListMessages;
        }
        public override string ToString()
        {
            var fullMessage = string.Empty;
            foreach(var item in ListMessages)
            {
                if (ListMessages.First().Equals(item))
                    fullMessage += item.Title + " \n" + item.Description;
                else
                    fullMessage += item.Description + "\n";
            }
            return fullMessage;
        }
    }
    public class Message
    {
        public Message()
        {
        }
        public Message(string Description)
        {
            this.Code = string.Empty;
            this.Title = string.Empty;
            this.Description = Description;
        }
        
        public Message(string Code, string Title, string Description)
        {
            this.Code = Code;
            this.Title = Title;
            this.Description = Description;
        }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
