using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToMany.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}