using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChat.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorChat.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set;  }
        public DbSet<Message> Messages { get; set; }
    }
}
