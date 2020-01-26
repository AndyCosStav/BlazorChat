using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace BlazorChat.Shared.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
       public string ContactMember { get; set;  }
    }
}
