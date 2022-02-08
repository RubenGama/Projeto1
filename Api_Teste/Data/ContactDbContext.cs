using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api_Teste.Models;

namespace Api_Teste.Data
{
    public class ContactDbContext:DbContext
    {
        public ContactDbContext(DbContextOptions options):base(options)
        {}
    
        public DbSet<Contact> Contacts { get; set; }
    
    }
}
