using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiPageDb.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Mark Smith",
                    PhoneNum = "(555)555-5555",
                    Address = "123 Main Street",
                    Note = "Friend"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Emily Mason",
                    PhoneNum = "(555)444-3333",
                    Address = "456 West Ave",
                    Note = "Mother"
                }
            );
        }
    }
}
