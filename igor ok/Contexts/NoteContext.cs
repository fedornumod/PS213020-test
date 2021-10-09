using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using igor_ok.Models;

namespace igor_ok.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {

        }

        public DbSet<Note> Notes { get; set; }

        public DbSet<igor_ok.Models.User> User { get; set; }

    }



}
