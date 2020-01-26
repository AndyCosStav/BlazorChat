using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChat.Shared.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }  
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime TimeSent { get; set;  }

    }
}
