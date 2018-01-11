using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToMany.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}