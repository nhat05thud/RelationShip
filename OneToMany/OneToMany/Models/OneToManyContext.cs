using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OneToMany.Models
{
    public class OneToManyContext : DbContext
    {
        public OneToManyContext() : base("OneToManyContext") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}