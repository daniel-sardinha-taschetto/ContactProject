using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactProject.Models
{
    public class Context : DbContext
    {
        
        public Context()
        {
            Database.SetInitializer<Context>(null);
            
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}