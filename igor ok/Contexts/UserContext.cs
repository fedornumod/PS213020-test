using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using igor_ok.Models;

  namespace igor_ok.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> option) : base(option)
        {

        }

        public DbSet<User> Users { get; set; }

    }


}

