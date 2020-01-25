using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChat.Shared.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }  
        public User Sender { get; set; }
        public User Receiver { get; set;  }

    }
}
