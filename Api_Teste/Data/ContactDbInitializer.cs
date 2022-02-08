using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Teste.Models;

namespace Api_Teste.Data
{
    public static class ContactDbInitializer
    {
        public static void Seed(this ContactDbContext context)
        {
            if (!context.Contacts.Any())
            {
                context.Contacts.Add(new Contact {Name="Ruben",
                
                    Email="Ruben.mail@sapo.pt",
                    Phone="963587456"
                });

                context.Contacts.Add(new Contact
                {
                    Name = "Miguel",

                    Email = "Miguel.mail@sapo.pt",
                    Phone = "963587458"
                });

                context.SaveChanges();
            }
        }
    }
}
