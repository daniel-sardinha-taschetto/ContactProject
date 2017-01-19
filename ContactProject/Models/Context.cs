using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactProject.Models
{
    public class Context : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}