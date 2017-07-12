using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityFramework.Entities;

using System.Data.Entity;

namespace EntityFramework
{
    public class ForumDBContext:DbContext
    {
     
        public DbSet<Post> Posts { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
