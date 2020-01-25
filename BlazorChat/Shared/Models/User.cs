using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChat.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Message> Messages { get; set;  }
        public string AccountId { get; set; }

    }
}
