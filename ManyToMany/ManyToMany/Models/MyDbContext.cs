using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManyToMany.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContext") { }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<AuthorToBook> AuthorToBook { get; set; }
    }
}